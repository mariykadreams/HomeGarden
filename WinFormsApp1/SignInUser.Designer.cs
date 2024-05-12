namespace UI1
{
    partial class SignInUser
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
            Welcome_Label = new Label();
            LearnMore_Label = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ClearFields_Label = new Label();
            logIn_Button = new Button();
            Exit_Label = new Label();
            txtUserName = new TextBox();
            txtpassword = new TextBox();
            Register_label = new Label();
            radioButton_user = new RadioButton();
            radioButton_admin = new RadioButton();
            UserorAdmin_Label = new Label();
            splitContainer_UserEmail = new SplitContainer();
            pictureBox1 = new PictureBox();
            Email_Label = new Label();
            splitContainer_UserPassword = new SplitContainer();
            pictureBox2 = new PictureBox();
            Password_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserEmail).BeginInit();
            splitContainer_UserEmail.Panel1.SuspendLayout();
            splitContainer_UserEmail.Panel2.SuspendLayout();
            splitContainer_UserEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserPassword).BeginInit();
            splitContainer_UserPassword.Panel1.SuspendLayout();
            splitContainer_UserPassword.Panel2.SuspendLayout();
            splitContainer_UserPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Welcome_Label
            // 
            Welcome_Label.AutoSize = true;
            Welcome_Label.Font = new Font("Elephant", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome_Label.Location = new Point(30, 40);
            Welcome_Label.Name = "Welcome_Label";
            Welcome_Label.Size = new Size(300, 47);
            Welcome_Label.TabIndex = 1;
            Welcome_Label.Text = "Welcome back!";
            // 
            // LearnMore_Label
            // 
            LearnMore_Label.AutoSize = true;
            LearnMore_Label.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LearnMore_Label.Location = new Point(34, 77);
            LearnMore_Label.Name = "LearnMore_Label";
            LearnMore_Label.Size = new Size(243, 29);
            LearnMore_Label.TabIndex = 2;
            LearnMore_Label.Text = "Let's Learn More About Plants";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 110, 73);
            panel2.Location = new Point(51, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 1);
            panel2.TabIndex = 6;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 110, 73);
            panel3.Location = new Point(48, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 1);
            panel3.TabIndex = 8;
            panel3.Visible = false;
            // 
            // ClearFields_Label
            // 
            ClearFields_Label.AutoSize = true;
            ClearFields_Label.Cursor = Cursors.Hand;
            ClearFields_Label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClearFields_Label.ForeColor = Color.FromArgb(44, 110, 73);
            ClearFields_Label.Location = new Point(259, 410);
            ClearFields_Label.Name = "ClearFields_Label";
            ClearFields_Label.Size = new Size(92, 26);
            ClearFields_Label.TabIndex = 10;
            ClearFields_Label.Text = "Clear Fields";
            ClearFields_Label.Visible = false;
            ClearFields_Label.Click += ClearFields_Label_Click;
            // 
            // logIn_Button
            // 
            logIn_Button.BackColor = Color.FromArgb(44, 110, 73);
            logIn_Button.Cursor = Cursors.Hand;
            logIn_Button.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logIn_Button.ForeColor = Color.White;
            logIn_Button.Location = new Point(52, 467);
            logIn_Button.Name = "logIn_Button";
            logIn_Button.Size = new Size(299, 55);
            logIn_Button.TabIndex = 11;
            logIn_Button.Text = "Sign In";
            logIn_Button.UseVisualStyleBackColor = false;
            logIn_Button.Visible = false;
            logIn_Button.Click += logIn_Button_Click;
            // 
            // Exit_Label
            // 
            Exit_Label.AutoSize = true;
            Exit_Label.Cursor = Cursors.Hand;
            Exit_Label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Exit_Label.ForeColor = Color.FromArgb(44, 110, 73);
            Exit_Label.Location = new Point(179, 554);
            Exit_Label.Name = "Exit_Label";
            Exit_Label.Size = new Size(38, 26);
            Exit_Label.TabIndex = 12;
            Exit_Label.Text = "Exit";
            Exit_Label.Click += Exit_Label_Click;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.FromArgb(44, 110, 73);
            txtUserName.Location = new Point(3, 22);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(256, 33);
            txtUserName.TabIndex = 13;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.FromArgb(44, 110, 73);
            txtpassword.Location = new Point(3, 22);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(256, 33);
            txtpassword.TabIndex = 14;
            txtpassword.KeyPress += txtpassword_KeyPress;
            // 
            // Register_label
            // 
            Register_label.AutoSize = true;
            Register_label.Cursor = Cursors.Hand;
            Register_label.Font = new Font("Sitka Banner", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            Register_label.ForeColor = Color.FromArgb(44, 110, 73);
            Register_label.Location = new Point(167, 525);
            Register_label.Name = "Register_label";
            Register_label.Size = new Size(67, 26);
            Register_label.TabIndex = 15;
            Register_label.Text = "Register";
            Register_label.Visible = false;
            Register_label.Click += Register_label_Click;
            // 
            // radioButton_user
            // 
            radioButton_user.AutoSize = true;
            radioButton_user.Font = new Font("Sitka Subheading", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton_user.Location = new Point(53, 178);
            radioButton_user.Name = "radioButton_user";
            radioButton_user.Size = new Size(68, 28);
            radioButton_user.TabIndex = 16;
            radioButton_user.Text = "User";
            radioButton_user.UseVisualStyleBackColor = true;
            radioButton_user.CheckedChanged += radioButton_user_CheckedChanged;
            // 
            // radioButton_admin
            // 
            radioButton_admin.AutoSize = true;
            radioButton_admin.Font = new Font("Sitka Subheading", 10.2F, FontStyle.Bold);
            radioButton_admin.Location = new Point(265, 178);
            radioButton_admin.Name = "radioButton_admin";
            radioButton_admin.Size = new Size(83, 28);
            radioButton_admin.TabIndex = 17;
            radioButton_admin.Text = "Admin";
            radioButton_admin.UseVisualStyleBackColor = true;
            radioButton_admin.CheckedChanged += radioButton_admin_CheckedChanged;
            // 
            // UserorAdmin_Label
            // 
            UserorAdmin_Label.AutoSize = true;
            UserorAdmin_Label.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserorAdmin_Label.Location = new Point(159, 143);
            UserorAdmin_Label.Name = "UserorAdmin_Label";
            UserorAdmin_Label.Size = new Size(76, 29);
            UserorAdmin_Label.TabIndex = 18;
            UserorAdmin_Label.Text = "You are:";
            // 
            // splitContainer_UserEmail
            // 
            splitContainer_UserEmail.Location = new Point(52, 256);
            splitContainer_UserEmail.Name = "splitContainer_UserEmail";
            // 
            // splitContainer_UserEmail.Panel1
            // 
            splitContainer_UserEmail.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer_UserEmail.Panel2
            // 
            splitContainer_UserEmail.Panel2.Controls.Add(Email_Label);
            splitContainer_UserEmail.Panel2.Controls.Add(txtUserName);
            splitContainer_UserEmail.Size = new Size(320, 51);
            splitContainer_UserEmail.SplitterDistance = 49;
            splitContainer_UserEmail.TabIndex = 19;
            splitContainer_UserEmail.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 39);
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
            // splitContainer_UserPassword
            // 
            splitContainer_UserPassword.Location = new Point(48, 339);
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
            splitContainer_UserPassword.Size = new Size(320, 51);
            splitContainer_UserPassword.SplitterDistance = 54;
            splitContainer_UserPassword.TabIndex = 20;
            splitContainer_UserPassword.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = UI.Properties.Resources.password_img;
            pictureBox2.Location = new Point(7, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 39);
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
            // SignInUser
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(419, 602);
            Controls.Add(splitContainer_UserPassword);
            Controls.Add(splitContainer_UserEmail);
            Controls.Add(UserorAdmin_Label);
            Controls.Add(radioButton_admin);
            Controls.Add(radioButton_user);
            Controls.Add(Register_label);
            Controls.Add(Exit_Label);
            Controls.Add(logIn_Button);
            Controls.Add(ClearFields_Label);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(LearnMore_Label);
            Controls.Add(Welcome_Label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignInUser";
            Text = "Sign in";
            Load += SignInUser_Load;
            splitContainer_UserEmail.Panel1.ResumeLayout(false);
            splitContainer_UserEmail.Panel2.ResumeLayout(false);
            splitContainer_UserEmail.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserEmail).EndInit();
            splitContainer_UserEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer_UserPassword.Panel1.ResumeLayout(false);
            splitContainer_UserPassword.Panel2.ResumeLayout(false);
            splitContainer_UserPassword.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_UserPassword).EndInit();
            splitContainer_UserPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Label LearnMore_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ClearFields_Label;
        private System.Windows.Forms.Button logIn_Button;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.Label UserorAdmin_Label;
        private System.Windows.Forms.SplitContainer splitContainer_UserEmail;
        private System.Windows.Forms.SplitContainer splitContainer_UserPassword;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Password_Label;
    }
}

