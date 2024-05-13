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

namespace UI.AdminPages
{
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
            UserService.UserLoadData(); 
            UsersDataGridView(UserService.Users);
        }
        private void UsersDataGridView(List<User> Users)
        {
            this.User_dataGridView.DataSource = null;
            this.User_dataGridView.DataSource = Users;

            this.User_dataGridView.Columns[0].HeaderText = "Guid Id";
            this.User_dataGridView.Columns[1].HeaderText = "Повне ім'я";
            this.User_dataGridView.Columns[2].HeaderText = "Email";
            this.User_dataGridView.Columns[3].HeaderText = "password";

            for (int i = 0; i < this.User_dataGridView.Columns.Count; i++)
            {
                this.User_dataGridView.Columns[i].Width = this.User_dataGridView.Width / this.User_dataGridView.Columns.Count;
            }
            this.User_dataGridView.ClearSelection();

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignOut_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
