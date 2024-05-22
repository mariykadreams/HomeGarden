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
using System.Threading;

namespace UI.AdminPages
{
    public partial class AllUsers : Form
    {
        User selectedUser;
        Thread th;

        public AllUsers()
        {
            InitializeComponent();
            UserService.UserLoadData();
            UsersDataGridView(UserService.Users);

            Delete_Button.Enabled = false;
        }
        private void dataGridView_editions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Delete_Button.Enabled = true;
            this.User_dataGridView.CurrentRow.Selected = true;
            selectedUser = UserService.Users.FirstOrDefault(user => user.Id == (Guid)this.User_dataGridView.CurrentRow.Cells["Id"].Value);
        }

        private void UsersDataGridView(List<User> Users)
        {
            this.User_dataGridView.DataSource = null;
            this.User_dataGridView.DataSource = Users;

            this.User_dataGridView.Columns[0].HeaderText = "Guid Id";
            this.User_dataGridView.Columns[1].HeaderText = "Full Name";
            this.User_dataGridView.Columns[2].HeaderText = "Email";
            this.User_dataGridView.Columns[3].HeaderText = "Password";
            this.User_dataGridView.Columns[4].HeaderText = "Data of Joining";

            for (int i = 0; i < this.User_dataGridView.Columns.Count; i++)
            {
                this.User_dataGridView.Columns[i].Width = this.User_dataGridView.Width / this.User_dataGridView.Columns.Count;
            }
            this.User_dataGridView.ClearSelection();

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

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?",
                "Confirmation of operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.User_dataGridView.SelectedRows.Count > 0)
                {
                    selectedUser = this.User_dataGridView.SelectedRows[0].DataBoundItem as User;
                    if (selectedUser != null)
                    {
                        UserService.DeleteUser(selectedUser);
                        UsersDataGridView(UserService.Users);
                        this.Delete_Button.Enabled = false;
                    }
                }
            }
        }

        private void User_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Delete_Button.Enabled = true;
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Openform(object obj)
        {
            Application.Run(new MainAdminPage());
        }


        private void AllUsers_Load(object sender, EventArgs e)
        {

        }
        private void AllUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AllVegetables_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenformVegetable);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenformVegetable(object obj)
        {
            Application.Run(new AllVegetables());
        }

        private void SignOut_Label_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
