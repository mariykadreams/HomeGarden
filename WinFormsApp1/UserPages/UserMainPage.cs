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

namespace UI.UserPages
{
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();
            UpdateWelcomeMessage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void UserMainPage_Load(object sender, EventArgs e)
        {

        }

        private void UpdateWelcomeMessage()
        {
            if (MyApplication.NowUser != null)
            {
                Welcome_label.Text = TruncateString($"Welcome, {MyApplication.NowUser.FullName}!", Welcome_label, "Welcome, ...");
            }
            else
            {
                Welcome_label.Text = "Welcome, User!";
            }
        }

        private string TruncateString(string text, Label label, string prefix = "")
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(text, label.Font);
                if (size.Width > label.Width)
                {
                    string ellipsis = "...";
                    float ellipsisWidth = g.MeasureString(ellipsis, label.Font).Width;

                    for (int i = text.Length - 1; i > 0; i--)
                    {
                        string truncatedText = text.Substring(0, i) + ellipsis;
                        size = g.MeasureString(truncatedText, label.Font);
                        if (size.Width <= label.Width)
                        {
                            return truncatedText;
                        }
                    }
                }
            }
            return text;
        }

    }
}
