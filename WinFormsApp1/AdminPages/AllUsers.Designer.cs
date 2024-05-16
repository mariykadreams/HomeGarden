namespace UI.AdminPages
{
    partial class AllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllUsers));
            panel2 = new Panel();
            Home_Button = new Button();
            SignOut_Button = new PictureBox();
            AllVegetables_Button = new Button();
            pictureBox1 = new PictureBox();
            SignOut_Label = new Label();
            SignUp_Button = new Button();
            Welcome_label = new Label();
            panel1 = new Panel();
            allUsers_Label = new Label();
            LearnMore_Label = new Label();
            User_dataGridView = new DataGridView();
            Delete_Button = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SignOut_Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 100, 73);
            panel2.Controls.Add(Home_Button);
            panel2.Controls.Add(SignOut_Button);
            panel2.Controls.Add(AllVegetables_Button);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(SignOut_Label);
            panel2.Controls.Add(SignUp_Button);
            panel2.Controls.Add(Welcome_label);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 612);
            panel2.TabIndex = 4;
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
            Home_Button.TabIndex = 39;
            Home_Button.Text = "Home";
            Home_Button.UseVisualStyleBackColor = false;
            Home_Button.Click += Home_Button_Click;
            // 
            // SignOut_Button
            // 
            SignOut_Button.Cursor = Cursors.Hand;
            SignOut_Button.Image = Properties.Resources.logout;
            SignOut_Button.Location = new Point(12, 555);
            SignOut_Button.Name = "SignOut_Button";
            SignOut_Button.Size = new Size(45, 45);
            SignOut_Button.SizeMode = PictureBoxSizeMode.StretchImage;
            SignOut_Button.TabIndex = 37;
            SignOut_Button.TabStop = false;
            SignOut_Button.Click += SignOut_Button_Click;
            // 
            // AllVegetables_Button
            // 
            AllVegetables_Button.BackColor = Color.FromArgb(44, 110, 73);
            AllVegetables_Button.Cursor = Cursors.Hand;
            AllVegetables_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllVegetables_Button.ForeColor = Color.White;
            AllVegetables_Button.Location = new Point(14, 334);
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
            // SignOut_Label
            // 
            SignOut_Label.AutoSize = true;
            SignOut_Label.Cursor = Cursors.Hand;
            SignOut_Label.Font = new Font("Sitka Subheading", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SignOut_Label.ForeColor = Color.White;
            SignOut_Label.Location = new Point(63, 567);
            SignOut_Label.Name = "SignOut_Label";
            SignOut_Label.Size = new Size(78, 24);
            SignOut_Label.TabIndex = 33;
            SignOut_Label.Text = "Sign Out";
            SignOut_Label.Click += SignOut_Label_Click;
            // 
            // SignUp_Button
            // 
            SignUp_Button.BackColor = Color.White;
            SignUp_Button.Cursor = Cursors.Hand;
            SignUp_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_Button.ForeColor = Color.FromArgb(44, 110, 73);
            SignUp_Button.Location = new Point(14, 273);
            SignUp_Button.Margin = new Padding(3, 4, 3, 4);
            SignUp_Button.Name = "SignUp_Button";
            SignUp_Button.Size = new Size(200, 40);
            SignUp_Button.TabIndex = 32;
            SignUp_Button.Text = "All Users";
            SignUp_Button.UseVisualStyleBackColor = false;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 110, 73);
            panel1.Controls.Add(allUsers_Label);
            panel1.Controls.Add(LearnMore_Label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 36);
            panel1.TabIndex = 3;
            // 
            // allUsers_Label
            // 
            allUsers_Label.AutoSize = true;
            allUsers_Label.Font = new Font("Elephant", 11.999999F);
            allUsers_Label.ForeColor = Color.White;
            allUsers_Label.Location = new Point(617, 7);
            allUsers_Label.Name = "allUsers_Label";
            allUsers_Label.Size = new Size(104, 26);
            allUsers_Label.TabIndex = 39;
            allUsers_Label.Text = "All Users";
            // 
            // LearnMore_Label
            // 
            LearnMore_Label.AutoSize = true;
            LearnMore_Label.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LearnMore_Label.ForeColor = Color.White;
            LearnMore_Label.Location = new Point(44, 2);
            LearnMore_Label.Name = "LearnMore_Label";
            LearnMore_Label.Size = new Size(150, 29);
            LearnMore_Label.TabIndex = 38;
            LearnMore_Label.Text = "HomeGarden";
            // 
            // User_dataGridView
            // 
            User_dataGridView.BackgroundColor = Color.FromArgb(44, 110, 73);
            User_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            User_dataGridView.GridColor = Color.White;
            User_dataGridView.Location = new Point(376, 74);
            User_dataGridView.Name = "User_dataGridView";
            User_dataGridView.RowHeadersWidth = 51;
            User_dataGridView.Size = new Size(640, 331);
            User_dataGridView.TabIndex = 5;
            User_dataGridView.CellContentClick += User_dataGridView_CellContentClick;
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(658, 446);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(94, 29);
            Delete_Button.TabIndex = 6;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // AllUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1149, 648);
            Controls.Add(Delete_Button);
            Controls.Add(User_dataGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AllUsers";
            Text = "AllUsers";
            Load += AllUsers_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SignOut_Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)User_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox SignOut_Button;
        private Button AllVegetables_Button;
        private PictureBox pictureBox1;
        private Label SignOut_Label;
        private Button SignUp_Button;
        private Label Welcome_label;
        private Panel panel1;
        private Label allUsers_Label;
        private Label LearnMore_Label;
        private DataGridView User_dataGridView;
        private Button Home_Button;
        private Button Delete_Button;
    }
}