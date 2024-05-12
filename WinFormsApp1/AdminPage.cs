using HomeGarden;
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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }


        // Функція для заповнення dataGridVew читачів.
        private void UsersDataGridView(List<User> Users)
        {
            this.User_dataGridView.DataSource = null;
            this.User_dataGridView.DataSource = Users;

            this.User_dataGridView.Columns[0].HeaderText = "Код читача";
            this.User_dataGridView.Columns[1].HeaderText = "Повне ім'я";
            this.User_dataGridView.Columns[2].HeaderText = "Email";
            this.User_dataGridView.Columns[3].HeaderText = "password";

            for (int i = 0; i < this.User_dataGridView.Columns.Count; i++)
            {
                this.User_dataGridView.Columns[i].Width = this.User_dataGridView.Width / this.User_dataGridView.Columns.Count;
            }
            this.User_dataGridView.ClearSelection();

        }
    }
}
