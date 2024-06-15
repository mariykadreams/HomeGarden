namespace UI
{
    partial class MainAdminPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminPage));
            panel1 = new Panel();
            allUsers_Label = new Label();
            LearnMore_Label = new Label();
            panel2 = new Panel();
            Home_Button = new Button();
            pictureBox2 = new PictureBox();
            AllVegetables_Button = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AllUsers_Button = new Button();
            Welcome_label = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label2_plants = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            All_Users = new Label();
            Time_Input = new Label();
            Date_Input = new Label();
            Time_Label = new Label();
            Date_Label = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 110, 73);
            panel1.Controls.Add(allUsers_Label);
            panel1.Controls.Add(LearnMore_Label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 36);
            panel1.TabIndex = 1;
            // 
            // allUsers_Label
            // 
            allUsers_Label.AutoSize = true;
            allUsers_Label.Font = new Font("Elephant", 11.999999F);
            allUsers_Label.ForeColor = Color.White;
            allUsers_Label.Location = new Point(633, 7);
            allUsers_Label.Name = "allUsers_Label";
            allUsers_Label.Size = new Size(73, 26);
            allUsers_Label.TabIndex = 40;
            allUsers_Label.Text = "Home";
            // 
            // LearnMore_Label
            // 
            LearnMore_Label.AutoSize = true;
            LearnMore_Label.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LearnMore_Label.ForeColor = Color.White;
            LearnMore_Label.Location = new Point(44, 4);
            LearnMore_Label.Name = "LearnMore_Label";
            LearnMore_Label.Size = new Size(150, 29);
            LearnMore_Label.TabIndex = 38;
            LearnMore_Label.Text = "HomeGarden";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 110, 73);
            panel2.Controls.Add(Home_Button);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(AllVegetables_Button);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AllUsers_Button);
            panel2.Controls.Add(Welcome_label);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 612);
            panel2.TabIndex = 2;
            // 
            // Home_Button
            // 
            Home_Button.BackColor = Color.White;
            Home_Button.Cursor = Cursors.Hand;
            Home_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home_Button.ForeColor = Color.FromArgb(44, 110, 73);
            Home_Button.Location = new Point(14, 214);
            Home_Button.Margin = new Padding(3, 4, 3, 4);
            Home_Button.Name = "Home_Button";
            Home_Button.Size = new Size(200, 40);
            Home_Button.TabIndex = 38;
            Home_Button.Text = "Home";
            Home_Button.UseVisualStyleBackColor = false;
            Home_Button.Click += Home_Button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.logout;
            pictureBox2.Location = new Point(12, 555);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AllVegetables_Button
            // 
            AllVegetables_Button.BackColor = Color.FromArgb(44, 110, 73);
            AllVegetables_Button.Cursor = Cursors.Hand;
            AllVegetables_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllVegetables_Button.ForeColor = Color.White;
            AllVegetables_Button.Location = new Point(14, 335);
            AllVegetables_Button.Margin = new Padding(3, 4, 3, 4);
            AllVegetables_Button.Name = "AllVegetables_Button";
            AllVegetables_Button.Size = new Size(200, 40);
            AllVegetables_Button.TabIndex = 36;
            AllVegetables_Button.Text = "All Plants";
            AllVegetables_Button.UseVisualStyleBackColor = false;
            AllVegetables_Button.Click += AllVegetables_Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Sitka Subheading", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 567);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 33;
            label1.Text = "Sign Out";
            label1.Click += label1_Click;
            // 
            // AllUsers_Button
            // 
            AllUsers_Button.BackColor = Color.FromArgb(44, 110, 73);
            AllUsers_Button.Cursor = Cursors.Hand;
            AllUsers_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllUsers_Button.ForeColor = Color.White;
            AllUsers_Button.Location = new Point(14, 274);
            AllUsers_Button.Margin = new Padding(3, 4, 3, 4);
            AllUsers_Button.Name = "AllUsers_Button";
            AllUsers_Button.Size = new Size(200, 40);
            AllUsers_Button.TabIndex = 32;
            AllUsers_Button.Text = "All Users";
            AllUsers_Button.UseVisualStyleBackColor = false;
            AllUsers_Button.Click += AllUsers_Button_Click;
            // 
            // Welcome_label
            // 
            Welcome_label.AutoSize = true;
            Welcome_label.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome_label.ForeColor = Color.White;
            Welcome_label.Location = new Point(26, 154);
            Welcome_label.Name = "Welcome_label";
            Welcome_label.Size = new Size(188, 26);
            Welcome_label.TabIndex = 30;
            Welcome_label.Text = "Welcome, Admin!";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(Time_Input);
            panel3.Controls.Add(Date_Input);
            panel3.Controls.Add(Time_Label);
            panel3.Controls.Add(Date_Label);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 612);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2_plants);
            panel5.Location = new Point(562, 154);
            panel5.Name = "panel5";
            panel5.Size = new Size(241, 195);
            panel5.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(58, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(112, 112);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 156);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 1;
            label3.Text = "_";
            // 
            // label2_plants
            // 
            label2_plants.AutoSize = true;
            label2_plants.Location = new Point(36, 126);
            label2_plants.Name = "label2_plants";
            label2_plants.Size = new Size(174, 20);
            label2_plants.TabIndex = 0;
            label2_plants.Text = "Current amount of plants";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(All_Users);
            panel4.Location = new Point(79, 154);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 195);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(58, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 156);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 1;
            label2.Text = "_";
            label2.Click += label2_Click;
            // 
            // All_Users
            // 
            All_Users.AutoSize = true;
            All_Users.Location = new Point(36, 126);
            All_Users.Name = "All_Users";
            All_Users.Size = new Size(167, 20);
            All_Users.TabIndex = 0;
            All_Users.Text = "Current amount of users";
            All_Users.Click += All_Users_Click;
            // 
            // Time_Input
            // 
            Time_Input.AutoSize = true;
            Time_Input.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            Time_Input.Location = new Point(451, 41);
            Time_Input.Name = "Time_Input";
            Time_Input.Size = new Size(40, 20);
            Time_Input.TabIndex = 3;
            Time_Input.Text = "Date";
            Time_Input.Click += Time_Input_Click;
            // 
            // Date_Input
            // 
            Date_Input.AutoSize = true;
            Date_Input.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            Date_Input.Location = new Point(451, 82);
            Date_Input.Name = "Date_Input";
            Date_Input.Size = new Size(41, 20);
            Date_Input.TabIndex = 2;
            Date_Input.Text = "Time";
            Date_Input.Click += Date_Input_Click;
            // 
            // Time_Label
            // 
            Time_Label.AutoSize = true;
            Time_Label.Font = new Font("Elephant", 9F);
            Time_Label.Location = new Point(342, 82);
            Time_Label.Name = "Time_Label";
            Time_Label.Size = new Size(48, 20);
            Time_Label.TabIndex = 1;
            Time_Label.Text = "Time";
            // 
            // Date_Label
            // 
            Date_Label.AutoSize = true;
            Date_Label.Font = new Font("Elephant", 9F);
            Date_Label.Location = new Point(342, 41);
            Date_Label.Name = "Date_Label";
            Date_Label.Size = new Size(46, 20);
            Date_Label.TabIndex = 0;
            Date_Label.Text = "Date";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MainAdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1149, 648);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainAdminPage";
            Text = "AdminPage";
            Load += MainAdminPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label Welcome_label;
        private Label label1;
        private Button AllUsers_Button;
        private PictureBox pictureBox1;
        private Button AllVegetables_Button;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private Label LearnMore_Label;
        private Button Home_Button;
        private Label allUsers_Label;
        private Label Time_Input;
        private Label Date_Input;
        private Label Time_Label;
        private Label Date_Label;
        private System.Windows.Forms.Timer timer1;
        private Panel panel5;
        private Label label3;
        private Label label2_plants;
        private Panel panel4;
        private Label label2;
        private Label All_Users;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}