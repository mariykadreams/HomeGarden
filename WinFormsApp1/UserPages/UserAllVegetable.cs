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
using UI.Multifunctional;

namespace UI.UserPages
{
    public partial class UserAllVegetable : Form
    {
        Thread th;

        public UserAllVegetable()
        {
            InitializeComponent();
            PlantService.LoadPlantsFromXml();
            PlantsDataGridView(PlantService.Plants);
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
            this.dataGridView1.Columns["WateringFrequency"].HeaderText = "Water";

            for (int i = 1; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Width = this.dataGridView1.Width / this.dataGridView1.Columns.Count;
            }

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
                case "Water":
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
