using HomeGarden.Core_Aplication;
using HomeGarden.Models;
using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace UI.UserPages
{
    public partial class UserMainPage : Form
    {
        Thread th;

        public UserMainPage()
        {
            InitializeComponent();
            UpdateWelcomeMessage();
            MyPlantsUpdate(MyApplication.NowUser.MyPlants);
            this.Shown += UserMainPage_Shown; 
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            };
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void UserMainPage_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (this.dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Type":
                    UserService.SortPlantsByType(MyApplication.NowUser);
                    break;
                case "Name":
                    UserService.SortPlantsByName(MyApplication.NowUser);
                    break;
                case "Species":
                    UserService.SortPlantsBySpecies(MyApplication.NowUser);
                    break;
                case "Location":
                    UserService.SortPlantsByLocation(MyApplication.NowUser);
                    break;
                case "Status":
                    UserService.SortPlantsByStatus(MyApplication.NowUser);
                    break;
                case "Level":
                    UserService.SortPlantsByLevel(MyApplication.NowUser);
                    break;
                case "WateringFrequency":
                    UserService.SortPlantsByWateringFrequency(MyApplication.NowUser);
                    break;
                default:
                    break;
            }
            MyPlantsUpdate(MyApplication.NowUser.MyPlants);
        }


        private void MyPlantsUpdate(List<Plant> plants)
        {
            if (MyApplication.NowUser.MyPlants.Count == 0)
            {
                this.dataGridView1.Visible = false;
                this.Lebel_above_DataGrid.Visible = true;
                View_Button.Enabled = false;
                button_Delete.Enabled = false;
            }
            else
            {
                this.Lebel_above_DataGrid.Visible = false;
                this.dataGridView1.Visible = true;

                this.dataGridView1.DataSource = null;

                this.dataGridView1.DataSource = MyApplication.NowUser.MyPlants;

                this.dataGridView1.Columns["Id"].Visible = false;
                this.dataGridView1.Columns[1].HeaderText = "Type";
                this.dataGridView1.Columns[2].HeaderText = "Name";
                this.dataGridView1.Columns[3].HeaderText = "Species";
                this.dataGridView1.Columns[4].HeaderText = "Location";
                this.dataGridView1.Columns[5].HeaderText = "Status";
                this.dataGridView1.Columns[6].HeaderText = "Short Description";
                this.dataGridView1.Columns[7].HeaderText = "Level";
                this.dataGridView1.Columns[8].HeaderText = "Water";

                for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
                {
                    this.dataGridView1.Columns[i].Width = this.dataGridView1.Width / (this.dataGridView1.Columns.Count - 1);
                }
            }

            dataGridView1.ClearSelection();
            UpdateButtonsState();
        }

        private void UserMainPage_Shown(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            UpdateButtonsState();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        private void UpdateWelcomeMessage()
        {
            if (MyApplication.NowUser != null)
            {
                Welcome_label.Text = TruncateString($"Welcome, {MyApplication.NowUser.FullName}!", Welcome_label, "Welcome, ...");
            }
            else
            {
                Welcome_label.Text = "Welcome, User!";
            }
        }

        private string TruncateString(string text, Label label, string prefix = "")
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(text, label.Font);
                if (size.Width > label.Width)
                {
                    string ellipsis = "...";
                    float ellipsisWidth = g.MeasureString(ellipsis, label.Font).Width;

                    for (int i = text.Length - 1; i > 0; i--)
                    {
                        string truncatedText = text.Substring(0, i) + ellipsis;
                        size = g.MeasureString(truncatedText, label.Font);
                        if (size.Width <= label.Width)
                        {
                            return truncatedText;
                        }
                    }
                }
            }
            return text;
        }

        private void LearnMore_Label_Click(object sender, EventArgs e)
        {

        }

        private void AllVegetables_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenUserAllVegetable);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenUserAllVegetable(object obj)
        {
            Application.Run(new UserAllVegetable());
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Plant selectedPlant = dataGridView1.SelectedRows[0].DataBoundItem as Plant;

                if (selectedPlant != null)
                {
                    string currentUserId = MyApplication.CurrentUserId;

                    UserService.DeletePlantFromUser(MyApplication.NowUser, selectedPlant);

                    UserWateringService.DeleteWateringInfo(currentUserId, selectedPlant.Id.ToString());

                    MyPlantsUpdate(MyApplication.NowUser.MyPlants);
                }
            }
        }


        private void View_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Plant selectedPlant = dataGridView1.SelectedRows[0].DataBoundItem as Plant;

                if (selectedPlant != null)
                {
                    var plantInfo = new UserPlantInfo(selectedPlant);
                    plantInfo.FormClosed += PlantInfo_FormClosed;
                    plantInfo.ShowDialog();
                }
            }
        }

        private void PlantInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlantService.LoadPlantsFromXml();
            MyPlantsUpdate(MyApplication.NowUser.MyPlants);
        }

        private void UpdateButtonsState()
        {
            bool hasPlants = MyApplication.NowUser.MyPlants.Count > 0;
            bool isPlantSelected = dataGridView1.SelectedRows.Count > 0;

            View_Button.Enabled = hasPlants && isPlantSelected;
            button_Delete.Enabled = hasPlants && isPlantSelected;
        }
    }
}
