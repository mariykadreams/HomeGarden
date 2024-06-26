﻿namespace UI.AdminPages
{
    partial class AllVegetables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllVegetables));
            panel1 = new Panel();
            panel5 = new Panel();
            allVegetables_Label = new Label();
            LearnMore_Label = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            Home_Button = new Button();
            pictureBox2 = new PictureBox();
            AllVegetables_Button = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AllUsers_Button = new Button();
            Welcome_label = new Label();
            dataGridView1 = new DataGridView();
            Add_Button = new Button();
            Delete_Button = new Button();
            View_Button = new Button();
            radioButton_All = new RadioButton();
            radioButton_Filtration = new RadioButton();
            panel4 = new Panel();
            panel_Data = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel_Data.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 110, 73);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(allVegetables_Label);
            panel1.Controls.Add(LearnMore_Label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 36);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point(250, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(803, 491);
            panel5.TabIndex = 11;
            // 
            // allVegetables_Label
            // 
            allVegetables_Label.AutoSize = true;
            allVegetables_Label.Font = new Font("Elephant", 11.999999F);
            allVegetables_Label.ForeColor = Color.White;
            allVegetables_Label.Location = new Point(653, 7);
            allVegetables_Label.Name = "allVegetables_Label";
            allVegetables_Label.Size = new Size(112, 26);
            allVegetables_Label.TabIndex = 40;
            allVegetables_Label.Text = "All Plants";
            allVegetables_Label.Click += allVegetables_Label_Click;
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
            panel2.Controls.Add(panel3);
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
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(250, 487);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 39;
            // 
            // Home_Button
            // 
            Home_Button.BackColor = Color.FromArgb(44, 110, 73);
            Home_Button.Cursor = Cursors.Hand;
            Home_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home_Button.ForeColor = Color.White;
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
            AllVegetables_Button.BackColor = Color.White;
            AllVegetables_Button.Cursor = Cursors.Hand;
            AllVegetables_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllVegetables_Button.ForeColor = Color.FromArgb(44, 110, 73);
            AllVegetables_Button.Location = new Point(14, 335);
            AllVegetables_Button.Margin = new Padding(3, 4, 3, 4);
            AllVegetables_Button.Name = "AllVegetables_Button";
            AllVegetables_Button.Size = new Size(200, 40);
            AllVegetables_Button.TabIndex = 36;
            AllVegetables_Button.Text = "All Plants";
            AllVegetables_Button.UseVisualStyleBackColor = false;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = Color.FromArgb(44, 110, 73);
            dataGridView1.Location = new Point(1, 1);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(899, 486);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            // 
            // Add_Button
            // 
            Add_Button.BackColor = Color.White;
            Add_Button.Location = new Point(19, 46);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(94, 29);
            Add_Button.TabIndex = 5;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.White;
            Delete_Button.Enabled = false;
            Delete_Button.Location = new Point(283, 46);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(94, 29);
            Delete_Button.TabIndex = 6;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // View_Button
            // 
            View_Button.BackColor = Color.White;
            View_Button.Enabled = false;
            View_Button.Location = new Point(153, 46);
            View_Button.Name = "View_Button";
            View_Button.Size = new Size(94, 29);
            View_Button.TabIndex = 7;
            View_Button.Text = "View";
            View_Button.UseVisualStyleBackColor = false;
            View_Button.Click += View_Button_Click;
            // 
            // radioButton_All
            // 
            radioButton_All.AutoSize = true;
            radioButton_All.BackColor = SystemColors.Control;
            radioButton_All.Checked = true;
            radioButton_All.Location = new Point(663, 52);
            radioButton_All.Name = "radioButton_All";
            radioButton_All.Size = new Size(48, 24);
            radioButton_All.TabIndex = 8;
            radioButton_All.TabStop = true;
            radioButton_All.Text = "All";
            radioButton_All.UseVisualStyleBackColor = false;
            radioButton_All.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton_Filtration
            // 
            radioButton_Filtration.AutoSize = true;
            radioButton_Filtration.BackColor = SystemColors.Control;
            radioButton_Filtration.Location = new Point(764, 51);
            radioButton_Filtration.Name = "radioButton_Filtration";
            radioButton_Filtration.Size = new Size(89, 24);
            radioButton_Filtration.TabIndex = 9;
            radioButton_Filtration.Text = "Filtration";
            radioButton_Filtration.UseVisualStyleBackColor = false;
            radioButton_Filtration.CheckedChanged += radioButton_Filtration_CheckedChanged;
            radioButton_Filtration.Click += radioButton_Filtration_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(Delete_Button);
            panel4.Controls.Add(radioButton_Filtration);
            panel4.Controls.Add(Add_Button);
            panel4.Controls.Add(radioButton_All);
            panel4.Controls.Add(View_Button);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(250, 522);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 126);
            panel4.TabIndex = 10;
            // 
            // panel_Data
            // 
            panel_Data.Controls.Add(dataGridView1);
            panel_Data.Dock = DockStyle.Fill;
            panel_Data.Location = new Point(250, 36);
            panel_Data.Name = "panel_Data";
            panel_Data.Size = new Size(899, 486);
            panel_Data.TabIndex = 11;
            // 
            // AllVegetables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 648);
            Controls.Add(panel_Data);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AllVegetables";
            Text = "AllVegetables";
            Load += AllVegetables_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel_Data.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label allVegetables_Label;
        private Label LearnMore_Label;
        private Panel panel2;
        private Button Home_Button;
        private PictureBox pictureBox2;
        private Button AllVegetables_Button;
        private PictureBox pictureBox1;
        private Label label1;
        private Button AllUsers_Button;
        private Label Welcome_label;
        private DataGridView dataGridView1;
        private Button Add_Button;
        private Button Delete_Button;
        private Button View_Button;
        private RadioButton radioButton_All;
        private RadioButton radioButton_Filtration;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel_Data;
    }
}
