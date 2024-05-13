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

namespace UI
{
    public partial class AllUsersMiniPage : UserControl
    {
        public AllUsersMiniPage()
        {
            InitializeComponent();
            UserService.UserLoadData();
            UsersDataGridView(UserService.Users);
        }

        private void User_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Функція для заповнення dataGridVew читачів.
        private void UsersDataGridView(List<User> Users)
        {
            this.User_dataGrid.DataSource = null;
            this.User_dataGrid.DataSource = Users;

            this.User_dataGrid.Columns[0].HeaderText = "Guid Id";
            this.User_dataGrid.Columns[1].HeaderText = "Повне ім'я";
            this.User_dataGrid.Columns[2].HeaderText = "Email";
            this.User_dataGrid.Columns[3].HeaderText = "password";

            for (int i = 0; i < this.User_dataGrid.Columns.Count; i++)
            {
                this.User_dataGrid.Columns[i].Width = this.User_dataGrid.Width / this.User_dataGrid.Columns.Count;
            }
            this.User_dataGrid.ClearSelection();

        }
    }
}
