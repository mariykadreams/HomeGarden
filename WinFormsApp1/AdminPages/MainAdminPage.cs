using HomeGarden.Core_Aplication;
using HomeGarden.Models;
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
using System.Threading;
using HomeGarden.Plants;

namespace UI
{
    public partial class MainAdminPage : Form
    {
        Thread th;

        public MainAdminPage()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Date_Input_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date_Input.Text = DateTime.Now.ToLongTimeString();
            Time_Input.Text = DateTime.Now.ToLongDateString();
        }

        private void MainAdminPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            PlantService.LoadPlantsFromXml();

            label2.Text = UserService.Users.Count.ToString();
            label3.Text = PlantService.Plants.Count.ToString();

        }

        private void Time_Input_Click(object sender, EventArgs e)
        {

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

        private void AllVegetables_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenformAllVegetables);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenformAllVegetables(object obj)
        {
            Application.Run(new AllVegetables());
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void All_Users_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
