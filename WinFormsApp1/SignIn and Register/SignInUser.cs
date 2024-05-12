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
using UI;
using UI.UserPages;

namespace UI1
{
    public partial class SignInUser : Form
    {
        string adminE = "admin06@gmail.com";
        string adminP = "1234";

        public SignInUser()
        {
            InitializeComponent();
        }

        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ClearFields_Label_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void logIn_Button_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == String.Empty)
            {
                MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.radioButton_user.Checked)
            {
                // Перерівка, чи існує читач з введеним кодом.
                bool userExists = false;
                foreach (User users in MyApplicationService.Users)
                {
                    if (users.Email == txtUserName.Text)
                    {
                        userExists = true;
                        break;
                    }
                }

                if (!userExists)
                {
                    DialogResult result = MessageBox.Show("Читач з таким кодом не знайден.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        this.txtUserName.Text = String.Empty;
                        this.txtpassword.Text = String.Empty;
                        this.txtUserName.Focus();
                    }
                }
                else
                {
                    MyApplication.UserMode = MyApplication.Mode.User;
                    MyApplication.NowUser = MyApplicationService.Users.FirstOrDefault(user => user.Email == txtUserName.Text);


                    this.Hide();
                    UserMainPage userMainForm = new UserMainPage();
                    userMainForm.Closed += (s, args) => this.Close();
                    userMainForm.Show();
                }
            }




            else if (this.radioButton_admin.Checked)
            {
                // Перевірка правильності пароля .
                if (this.txtUserName.Text == adminE && this.txtpassword.Text == adminP)
                {
                    MyApplication.UserMode = MyApplication.Mode.Admin;
                    this.Hide();
                    var MainAdminPage = new MainAdminPage();
                    MainAdminPage.Closed += (s, args) => this.Close();
                    MainAdminPage.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Неправильний пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        this.txtUserName.Text = String.Empty;
                        this.txtpassword.Text = String.Empty;
                        this.txtUserName.Focus();
                    }
                }
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void SignInUser_Load(object sender, EventArgs e)
        {
            MyApplicationService.UserLoadData();
        }

        private void radioButton_user_CheckedChanged(object sender, EventArgs e)
        {
            this.splitContainer_UserEmail.Visible = true;
            this.logIn_Button.Visible = true;
            this.splitContainer_UserPassword.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.Password_Label.Text = "Password";
            this.Welcome_Label.Text = "Welcome back!";
            this.LearnMore_Label.Text = "Let's Learn More About Plants";
            this.txtUserName.Focus();
            this.Register_label.Visible = true;
            this.ClearFields_Label.Visible= true;
        }

        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            this.splitContainer_UserEmail.Visible = true;
            this.splitContainer_UserPassword.Visible = true;
            this.Register_label.Visible = false;
            this.logIn_Button.Visible = true;
            this.ClearFields_Label.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.Password_Label.Text = "Admin Password";
            this.Welcome_Label.Text = "Welcome Admin!";
            this.LearnMore_Label.Text = "Let's Help People Learn More About Plants";
            this.txtUserName.Focus();
        }

        private void Register_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.Closed += (s, args) => this.Close();
            Register.Show();
        }
    }
}
