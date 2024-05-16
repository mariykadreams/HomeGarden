using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HomeGarden.Plants;

namespace UI.AdminPages
{
    public partial class AllVegetables : Form
    {
        Thread th;

        public AllVegetables()
        {
            InitializeComponent();
            PlantService.LoadPlantsFromXml();
            PlantsDataGridView(PlantService.Plants);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllUsers_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenformAllUsers);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenformAllUsers(object obj)
        {
            Application.Run(new AllUsers());
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenformHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenformHome(object obj)
        {
            Application.Run(new MainAdminPage());
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            NewPlant NewPlant = new NewPlant();
            NewPlant.ShowDialog();
            if (NewPlant.PlantAdded)
            {
                PlantService.LoadPlantsFromXml();
                PlantsDataGridView(PlantService.Plants);
            }
        }

        private void AllVegetables_Load(object sender, EventArgs e)
        {

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

            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Width = this.dataGridView1.Width / this.dataGridView1.Columns.Count;
            }
            this.dataGridView1.ClearSelection();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Plant selectedPlant = dataGridView1.SelectedRows[0].DataBoundItem as Plant;

                if (selectedPlant != null)
                {
                    PlantService.DeletePlant(selectedPlant);
                    PlantsDataGridView(PlantService.Plants);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Delete_Button.Enabled = true;
        }
    }
}
