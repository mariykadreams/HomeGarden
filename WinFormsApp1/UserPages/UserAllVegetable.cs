using HomeGarden.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HomeGarden.Core_Aplication;
using HomeGarden.Models;
using UI.Multifunctional;

namespace UI.UserPages
{
    public partial class UserAllVegetable : Form
    {
        Thread th;

        public UserAllVegetable()
        {
            InitializeComponent();
            UpdateWelcomeMessage();
            PlantService.LoadPlantsFromXml();
            PlantsDataGridView(PlantService.Plants);
            this.Shown += UserAllVegetable_Shown;
            this.dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.View_Button.Enabled = false;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Add_Button.Enabled = true;
                View_Button.Enabled = true;
            }
            else
            {
                Add_Button.Enabled = false;
                View_Button.Enabled = false;
            }
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

        private void PlantsDataGridView(List<Plant> plants)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = plants;

            this.dataGridView1.Columns["Id"].Visible = false;

            this.dataGridView1.Columns["Type"].HeaderText = "Type";
            this.dataGridView1.Columns["Name"].HeaderText = "Name";
            this.dataGridView1.Columns["Species"].HeaderText = "Species";
            this.dataGridView1.Columns["Location"].HeaderText = "Location";
            this.dataGridView1.Columns["Status"].HeaderText = "Status";
            this.dataGridView1.Columns["ShortDesciption"].HeaderText = "Short Description";
            this.dataGridView1.Columns["Level"].HeaderText = "Level";
            this.dataGridView1.Columns["WateringFrequency"].HeaderText = "Watering Frequency";

            for (int i = 1; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Width = this.dataGridView1.Width / this.dataGridView1.Columns.Count;
            }

            this.dataGridView1.ClearSelection();
        }

        private void UserAllVegetable_Shown(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection(); 
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (this.dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Type":
                    PlantService.SortPlantsByType();
                    break;
                case "Name":
                    PlantService.SortPlantsByName();
                    break;
                case "Species":
                    PlantService.SortPlantsBySpecies();
                    break;
                case "Location":
                    PlantService.SortPlantsByLocation();
                    break;
                case "Status":
                    PlantService.SortPlantsByStatus();
                    break;
                case "Level":
                    PlantService.SortPlantsByLevel();
                    break;
                case "WateringFrequency":
                    PlantService.SortPlantsByWateringFrequency();
                    break;
                default:
                    break;
            }
            PlantsDataGridView(PlantService.Plants);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.View_Button.Enabled = true;
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

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenUserMainPage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenUserMainPage(object obj)
        {
            Application.Run(new UserMainPage());
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Plant selectedPlant = dataGridView1.SelectedRows[0].DataBoundItem as Plant;

                if (selectedPlant != null)
                {
                    var userPlantInfo = new HomeGarden.Models.UserPlantInfo(selectedPlant);

                    User currentUser = MyApplication.NowUser;

                    if (currentUser != null)
                    {
                        if (!currentUser.MyPlants.Any(p => p.Id == selectedPlant.Id))
                        {
                            UserService.AddPlantToUser(currentUser, userPlantInfo);
                            MessageBox.Show("Plant added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error: This plant is already in your collection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Current user not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    var plantInfo = new PlantInfo(selectedPlant, true);
                    plantInfo.FormClosed += PlantInfo_FormClosed;
                    plantInfo.ShowDialog();
                }
            }
        }

        private void PlantInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlantService.LoadPlantsFromXml();
            PlantsDataGridView(PlantService.Plants);
        }

        private void radioButton_All_CheckedChanged(object sender, EventArgs e)
        {
            PlantsDataGridView(PlantService.Plants);
        }

        private void radioButton_Filtration_Click(object sender, EventArgs e)
        {
            var filtration = new Filtration();
            filtration.FilterApplied += Filtration_FilterApplied;
            filtration.ShowDialog();
        }

        private void Filtration_FilterApplied(object sender, EventArgs e)
        {
            var filtration = sender as Filtration;
            if (filtration != null)
            {
                PlantsDataGridView(filtration.SearchResultList);

                if (filtration.SearchResultList.Count == 0)
                {
                    MessageBox.Show("Unfortunately, nothing was found for your request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                filtration.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
