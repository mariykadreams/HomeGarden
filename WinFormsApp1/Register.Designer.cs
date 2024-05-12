namespace UI1
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer_UserPassword = new SplitContainer();
            pictureBox2 = new PictureBox();
            Password_Label = new Label();
            txtpassword = new TextBox();
            splitContainer_UserEmail = new SplitContainer();
            pictureBox1 = new PictureBox();
            Email_Label = new Label();
            txtUserEmail = new TextBox();
            SignUp_Button = new Button();
            ClearFields_Label = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            LearnMore_Label = new Label();
            Welcome_Label = new Label();
            splitContainer1 = new SplitContainer();
            pictureBox3 = new PictureBox();
            name_Label = new Label();
            txtUserName = new TextBox();
            panel1 = new Panel();
            splitContainer2 = new SplitContainer();
            pictureBox4 = new PictureBox();
            PasswordVerification_Label = new Label();
            txtpasswordVerification = new TextBox();
            panel4 = new Panel();
            GoBack_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserPassword).BeginInit();
            splitContainer_UserPassword.Panel1.SuspendLayout();
            splitContainer_UserPassword.Panel2.SuspendLayout();
            splitContainer_UserPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserEmail).BeginInit();
            splitContainer_UserEmail.Panel1.SuspendLayout();
            splitContainer_UserEmail.Panel2.SuspendLayout();
            splitContainer_UserEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // splitContainer_UserPassword
            // 
            splitContainer_UserPassword.Location = new Point(46, 386);
            splitContainer_UserPassword.Margin = new Padding(3, 4, 3, 4);
            splitContainer_UserPassword.Name = "splitContainer_UserPassword";
            // 
            // splitContainer_UserPassword.Panel1
            // 
            splitContainer_UserPassword.Panel1.Controls.Add(pictureBox2);
            // 
            // splitContainer_UserPassword.Panel2
            // 
            splitContainer_UserPassword.Panel2.Controls.Add(Password_Label);
            splitContainer_UserPassword.Panel2.Controls.Add(txtpassword);
            splitContainer_UserPassword.Size = new Size(320, 64);
            splitContainer_UserPassword.SplitterDistance = 54;
            splitContainer_UserPassword.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = UI.Properties.Resources.password_img;
            pictureBox2.Location = new Point(7, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Sitka Banner", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Password_Label.ForeColor = Color.FromArgb(44, 110, 73);
            Password_Label.Location = new Point(3, 0);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(57, 19);
            Password_Label.TabIndex = 22;
            Password_Label.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(44, 110, 73);
            txtpassword.Location = new Point(3, 28);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(256, 41);
            txtpassword.TabIndex = 14;
            // 
            // splitContainer_UserEmail
            // 
            splitContainer_UserEmail.Location = new Point(46, 284);
            splitContainer_UserEmail.Margin = new Padding(3, 4, 3, 4);
            splitContainer_UserEmail.Name = "splitContainer_UserEmail";
            // 
            // splitContainer_UserEmail.Panel1
            // 
            splitContainer_UserEmail.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer_UserEmail.Panel2
            // 
            splitContainer_UserEmail.Panel2.Controls.Add(Email_Label);
            splitContainer_UserEmail.Panel2.Controls.Add(txtUserEmail);
            splitContainer_UserEmail.Size = new Size(320, 64);
            splitContainer_UserEmail.SplitterDistance = 49;
            splitContainer_UserEmail.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 6);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 49);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Email_Label
            // 
            Email_Label.AutoSize = true;
            Email_Label.Font = new Font("Sitka Banner", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Email_Label.ForeColor = Color.FromArgb(44, 110, 73);
            Email_Label.Location = new Point(3, 0);
            Email_Label.Name = "Email_Label";
            Email_Label.Size = new Size(38, 19);
            Email_Label.TabIndex = 21;
            Email_Label.Text = "Email";
            // 
            // txtUserEmail
            // 
            txtUserEmail.BorderStyle = BorderStyle.None;
            txtUserEmail.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserEmail.ForeColor = Color.FromArgb(44, 110, 73);
            txtUserEmail.Location = new Point(3, 28);
            txtUserEmail.Margin = new Padding(3, 4, 3, 4);
            txtUserEmail.Multiline = true;
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(256, 41);
            txtUserEmail.TabIndex = 13;
            // 
            // SignUp_Button
            // 
            SignUp_Button.BackColor = Color.FromArgb(44, 110, 73);
            SignUp_Button.Cursor = Cursors.Hand;
            SignUp_Button.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_Button.ForeColor = Color.White;
            SignUp_Button.Location = new Point(59, 619);
            SignUp_Button.Margin = new Padding(3, 4, 3, 4);
            SignUp_Button.Name = "SignUp_Button";
            SignUp_Button.Size = new Size(299, 69);
            SignUp_Button.TabIndex = 26;
            SignUp_Button.Text = "Sign Up";
            SignUp_Button.UseVisualStyleBackColor = false;
            SignUp_Button.Click += SignUp_Button_Click;
            // 
            // ClearFields_Label
            // 
            ClearFields_Label.AutoSize = true;
            ClearFields_Label.Cursor = Cursors.Hand;
            ClearFields_Label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClearFields_Label.ForeColor = Color.FromArgb(44, 110, 73);
            ClearFields_Label.Location = new Point(275, 556);
            ClearFields_Label.Name = "ClearFields_Label";
            ClearFields_Label.Size = new Size(92, 26);
            ClearFields_Label.TabIndex = 25;
            ClearFields_Label.Text = "Clear Fields";
            ClearFields_Label.Click += ClearFields_Label_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 110, 73);
            panel3.Location = new Point(46, 458);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1);
            panel3.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 110, 73);
            panel2.Location = new Point(45, 355);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 23;
            // 
            // LearnMore_Label
            // 
            LearnMore_Label.AutoSize = true;
            LearnMore_Label.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LearnMore_Label.Location = new Point(42, 109);
            LearnMore_Label.Name = "LearnMore_Label";
            LearnMore_Label.Size = new Size(243, 29);
            LearnMore_Label.TabIndex = 30;
            LearnMore_Label.Text = "Let's Learn More About Plants";
            // 
            // Welcome_Label
            // 
            Welcome_Label.AutoSize = true;
            Welcome_Label.Font = new Font("Elephant", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome_Label.Location = new Point(38, 61);
            Welcome_Label.Name = "Welcome_Label";
            Welcome_Label.Size = new Size(204, 47);
            Welcome_Label.TabIndex = 29;
            Welcome_Label.Text = "Welcome!";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(47, 188);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(name_Label);
            splitContainer1.Panel2.Controls.Add(txtUserName);
            splitContainer1.Size = new Size(320, 64);
            splitContainer1.SplitterDistance = 49;
            splitContainer1.TabIndex = 32;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = UI.Properties.Resources.Untitled_design__1_;
            pictureBox3.Location = new Point(5, 13);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // name_Label
            // 
            name_Label.AutoSize = true;
            name_Label.Font = new Font("Sitka Banner", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name_Label.ForeColor = Color.FromArgb(44, 110, 73);
            name_Label.Location = new Point(3, 0);
            name_Label.Name = "name_Label";
            name_Label.Size = new Size(59, 19);
            name_Label.TabIndex = 21;
            name_Label.Text = "Full Name";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.FromArgb(44, 110, 73);
            txtUserName.Location = new Point(3, 28);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(256, 41);
            txtUserName.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 110, 73);
            panel1.Location = new Point(46, 259);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 31;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(46, 480);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(pictureBox4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(PasswordVerification_Label);
            splitContainer2.Panel2.Controls.Add(txtpasswordVerification);
            splitContainer2.Size = new Size(320, 64);
            splitContainer2.SplitterDistance = 54;
            splitContainer2.TabIndex = 34;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = UI.Properties.Resources.password_img;
            pictureBox4.Location = new Point(7, 13);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // PasswordVerification_Label
            // 
            PasswordVerification_Label.AutoSize = true;
            PasswordVerification_Label.Font = new Font("Sitka Banner", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordVerification_Label.ForeColor = Color.FromArgb(44, 110, 73);
            PasswordVerification_Label.Location = new Point(3, 0);
            PasswordVerification_Label.Name = "PasswordVerification_Label";
            PasswordVerification_Label.Size = new Size(117, 19);
            PasswordVerification_Label.TabIndex = 22;
            PasswordVerification_Label.Text = "Password Verification";
            // 
            // txtpasswordVerification
            // 
            txtpasswordVerification.BorderStyle = BorderStyle.None;
            txtpasswordVerification.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpasswordVerification.ForeColor = Color.FromArgb(44, 110, 73);
            txtpasswordVerification.Location = new Point(3, 28);
            txtpasswordVerification.Margin = new Padding(3, 4, 3, 4);
            txtpasswordVerification.Multiline = true;
            txtpasswordVerification.Name = "txtpasswordVerification";
            txtpasswordVerification.PasswordChar = '*';
            txtpasswordVerification.Size = new Size(256, 41);
            txtpasswordVerification.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(44, 110, 73);
            panel4.Location = new Point(46, 551);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 1);
            panel4.TabIndex = 33;
            // 
            // GoBack_Label
            // 
            GoBack_Label.AutoSize = true;
            GoBack_Label.Cursor = Cursors.Hand;
            GoBack_Label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GoBack_Label.ForeColor = Color.FromArgb(44, 110, 73);
            GoBack_Label.Location = new Point(174, 691);
            GoBack_Label.Name = "GoBack_Label";
            GoBack_Label.Size = new Size(68, 26);
            GoBack_Label.TabIndex = 35;
            GoBack_Label.Text = "Go Back";
            GoBack_Label.Click += GoBack_Label_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 752);
            Controls.Add(GoBack_Label);
            Controls.Add(splitContainer2);
            Controls.Add(panel4);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(LearnMore_Label);
            Controls.Add(Welcome_Label);
            Controls.Add(splitContainer_UserPassword);
            Controls.Add(splitContainer_UserEmail);
            Controls.Add(SignUp_Button);
            Controls.Add(ClearFields_Label);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Register";
            splitContainer_UserPassword.Panel1.ResumeLayout(false);
            splitContainer_UserPassword.Panel1.PerformLayout();
            splitContainer_UserPassword.Panel2.ResumeLayout(false);
            splitContainer_UserPassword.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserPassword).EndInit();
            splitContainer_UserPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            splitContainer_UserEmail.Panel1.ResumeLayout(false);
            splitContainer_UserEmail.Panel2.ResumeLayout(false);
            splitContainer_UserEmail.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserEmail).EndInit();
            splitContainer_UserEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_UserPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.SplitContainer splitContainer_UserEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Label ClearFields_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LearnMore_Label;
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label PasswordVerification_Label;
        private System.Windows.Forms.TextBox txtpasswordVerification;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label GoBack_Label;
    }
}