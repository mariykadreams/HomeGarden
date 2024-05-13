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

namespace UI
{
    public partial class MainAdminPage : Form
    {
        public MainAdminPage()
        {
            InitializeComponent();

        }

        private void AllUsers_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var allUsers = new AllUsers();
            allUsers.FormClosed += (s, args) => this.Show();
            allUsers.Show();
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
        }

        private void Time_Input_Click(object sender, EventArgs e)
        {

        }
    }
}
