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
            panel3.Controls.Add(Time_Input);
            panel3.Controls.Add(Date_Input);
            panel3.Controls.Add(Time_Label);
            panel3.Controls.Add(Date_Label);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 612);
            panel3.TabIndex = 3;
            // 
            // Time_Input
            // 
            Time_Input.AutoSize = true;
            Time_Input.Location = new Point(133, 47);
            Time_Input.Name = "Time_Input";
            Time_Input.Size = new Size(41, 20);
            Time_Input.TabIndex = 3;
            Time_Input.Text = "Date";
            Time_Input.Click += Time_Input_Click;
            // 
            // Date_Input
            // 
            Date_Input.AutoSize = true;
            Date_Input.Location = new Point(133, 88);
            Date_Input.Name = "Date_Input";
            Date_Input.Size = new Size(42, 20);
            Date_Input.TabIndex = 2;
            Date_Input.Text = "Time";
            Date_Input.Click += Date_Input_Click;
            // 
            // Time_Label
            // 
            Time_Label.AutoSize = true;
            Time_Label.Location = new Point(62, 88);
            Time_Label.Name = "Time_Label";
            Time_Label.Size = new Size(42, 20);
            Time_Label.TabIndex = 1;
            Time_Label.Text = "Time";
            // 
            // Date_Label
            // 
            Date_Label.AutoSize = true;
            Date_Label.Location = new Point(62, 47);
            Date_Label.Name = "Date_Label";
            Date_Label.Size = new Size(41, 20);
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
    }
}