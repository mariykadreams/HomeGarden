using HomeGarden.Core_Aplication;
using HomeGarden.Models;
using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AdminPages;
using UI.Multifunctional;

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

        private void MyPlantsUpdate(List<Plant> plants)
        {
            // Hide DataGridView if no plants
            if (MyApplication.NowUser.MyPlants.Count == 0)
            {
                this.dataGridView1.Visible = false;
                this.Lebel_above_DataGrid.Visible = true;
            }
            else
            {
                this.Lebel_above_DataGrid.Visible = false;
                this.dataGridView1.Visible = true;

                // Clear current DataSource before updating
                this.dataGridView1.DataSource = null;

                // Set the new DataSource
                this.dataGridView1.DataSource = MyApplication.NowUser.MyPlants;

                // Set column headers
                this.dataGridView1.Columns["Id"].Visible = false;
                this.dataGridView1.Columns[1].HeaderText = "Type";
                this.dataGridView1.Columns[2].HeaderText = "Name";
                this.dataGridView1.Columns[3].HeaderText = "Species";
                this.dataGridView1.Columns[4].HeaderText = "Location";
                this.dataGridView1.Columns[5].HeaderText = "Status";
                this.dataGridView1.Columns[6].HeaderText = "Short Description";
                this.dataGridView1.Columns[7].HeaderText = "Level";
                this.dataGridView1.Columns[8].HeaderText = "Water";

                // Adjust column widths
                for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
                {
                    this.dataGridView1.Columns[i].Width = this.dataGridView1.Width / this.dataGridView1.Columns.Count;
                }
            }
            // Clear selection to prevent issues with deleted rows
            dataGridView1.ClearSelection();
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
                // Get the selected plant from DataGridView
                Plant selectedPlant = dataGridView1.SelectedRows[0].DataBoundItem as Plant;

                if (selectedPlant != null)
                {
                    // Remove the plant from the user's plant list
                    UserService.DeletePlantFromUser(MyApplication.NowUser, selectedPlant);

                    // Update the DataGridView after deletion
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
                    var plantInfo = new PlantInfo(selectedPlant);
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

    }
}
