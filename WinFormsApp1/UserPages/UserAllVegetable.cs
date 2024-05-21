﻿using HomeGarden.Plants;
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

            this.dataGridView1.Columns[0].HeaderText = "Guid Id";
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
                this.dataGridView1.Columns[i].Width = this.dataGridView1.Width / this.dataGridView1.Columns.Count;
            }
            this.dataGridView1.ClearSelection();
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    PlantService.SortPlantsByType();
                    break;
                case 2:
                    PlantService.SortPlantsByName();
                    break;
                case 3:
                    PlantService.SortPlantsBySpecies();
                    break;
                case 4:
                    PlantService.SortPlantsByLocation();
                    break;
                case 5:
                    PlantService.SortPlantsByStatus();
                    break;
                case 7:
                    PlantService.SortPlantsByLevel();
                    break;
                case 8:
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
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
