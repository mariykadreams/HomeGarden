﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeGarden;


namespace UI1
{
    public partial class Register : Form
    {
        string adminE = "admin06@gmail.com";
        string adminP = "1234";

        public Register()
        {
            InitializeComponent();
        }  

        private void ClearFields_Label_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserEmail.Clear();
            txtpasswordVerification.Clear();
            txtUserName.Focus();
        }

        private void GoBack_Label_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SignIn = new SignInUser();
            SignIn.Closed += (s, args) => this.Close();
            SignIn.Show();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == String.Empty || txtpassword.Text == String.Empty || txtpasswordVerification.Text == String.Empty || txtUserEmail.Text == String.Empty)
            {
                MessageBox.Show("Fill in the field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text, @"^[a-zA-Zа-яА-ЯіІїЇґҐ'\s]*$"))
            {
                MessageBox.Show("Name can only contain letters, spaces, and apostrophes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(txtUserEmail.Text))
            {
                MessageBox.Show("Invalid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtpassword.Text != txtpasswordVerification.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MyApplicationService.Users != null && MyApplicationService.Users.Where(u => u.Email == txtUserEmail.Text).Count() == 0)
            {
                MyApplicationService.Users.Add(new User(txtUserName.Text, txtUserEmail.Text, txtpassword.Text));
                MessageBox.Show($"You have been successfully registered!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var SignIn = new SignInUser();
                SignIn.Closed += (s, args) => this.Close();
                SignIn.Show();
            }



            else
            {
                MessageBox.Show("This email adress is already useing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Перевірка відповідності формату електронної пошти за допомогою регулярного виразу
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
