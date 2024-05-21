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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInUser));
            Welcome_Label = new Label();
            LearnMore_Label = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ClearFields_Label = new Label();
            LogIn_Button = new Button();
            Exit_Label = new Label();
            txtUserName = new TextBox();
            Txtpassword = new TextBox();
            Register_label = new Label();
            RadioButton_user = new RadioButton();
            RadioButton_admin = new RadioButton();
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
            // LogIn_Button
            // 
            LogIn_Button.BackColor = Color.FromArgb(44, 110, 73);
            LogIn_Button.Cursor = Cursors.Hand;
            LogIn_Button.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogIn_Button.ForeColor = Color.White;
            LogIn_Button.Location = new Point(52, 467);
            LogIn_Button.Name = "LogIn_Button";
            LogIn_Button.Size = new Size(299, 55);
            LogIn_Button.TabIndex = 11;
            LogIn_Button.Text = "Sign In";
            LogIn_Button.UseVisualStyleBackColor = false;
            LogIn_Button.Visible = false;
            LogIn_Button.Click += LogIn_Button_Click;
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
            // Txtpassword
            // 
            Txtpassword.BorderStyle = BorderStyle.None;
            Txtpassword.Font = new Font("Mongolian Baiti", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txtpassword.ForeColor = Color.FromArgb(44, 110, 73);
            Txtpassword.Location = new Point(3, 22);
            Txtpassword.Multiline = true;
            Txtpassword.Name = "Txtpassword";
            Txtpassword.PasswordChar = '*';
            Txtpassword.Size = new Size(256, 33);
            Txtpassword.TabIndex = 14;
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
            // RadioButton_user
            // 
            RadioButton_user.AutoSize = true;
            RadioButton_user.Font = new Font("Sitka Subheading", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioButton_user.Location = new Point(53, 178);
            RadioButton_user.Name = "RadioButton_user";
            RadioButton_user.Size = new Size(68, 28);
            RadioButton_user.TabIndex = 16;
            RadioButton_user.Text = "User";
            RadioButton_user.UseVisualStyleBackColor = true;
            RadioButton_user.CheckedChanged += RadioButton_user_CheckedChanged;
            // 
            // RadioButton_admin
            // 
            RadioButton_admin.AutoSize = true;
            RadioButton_admin.Font = new Font("Sitka Subheading", 10.2F, FontStyle.Bold);
            RadioButton_admin.Location = new Point(265, 178);
            RadioButton_admin.Name = "RadioButton_admin";
            RadioButton_admin.Size = new Size(83, 28);
            RadioButton_admin.TabIndex = 17;
            RadioButton_admin.Text = "Admin";
            RadioButton_admin.UseVisualStyleBackColor = true;
            RadioButton_admin.CheckedChanged += RadioButton_admin_CheckedChanged;
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
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            splitContainer_UserPassword.Panel2.Controls.Add(Txtpassword);
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
            Controls.Add(RadioButton_admin);
            Controls.Add(RadioButton_user);
            Controls.Add(Register_label);
            Controls.Add(Exit_Label);
            Controls.Add(LogIn_Button);
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
        private System.Windows.Forms.Button LogIn_Button;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.RadioButton RadioButton_user;
        private System.Windows.Forms.RadioButton RadioButton_admin;
        private System.Windows.Forms.Label UserorAdmin_Label;
        private System.Windows.Forms.SplitContainer splitContainer_UserEmail;
        private System.Windows.Forms.SplitContainer splitContainer_UserPassword;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Password_Label;
    }
}

