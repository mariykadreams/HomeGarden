namespace UI.UserPages
{
    partial class UserMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainPage));
            panel1 = new Panel();
            allUsers_Label = new Label();
            LearnMore_Label = new Label();
            panel2 = new Panel();
            Home_Button = new Button();
            pictureBox2 = new PictureBox();
            AllVegetables_Button = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Welcome_label = new Label();
            panel4 = new Panel();
            button_Delete = new Button();
            View_Button = new Button();
            dataGridView1 = new DataGridView();
            Lebel_above_DataGrid = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.TabIndex = 4;
            // 
            // allUsers_Label
            // 
            allUsers_Label.AutoSize = true;
            allUsers_Label.Font = new Font("Elephant", 11.999999F);
            allUsers_Label.ForeColor = Color.White;
            allUsers_Label.Location = new Point(696, 4);
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
            LearnMore_Label.Click += LearnMore_Label_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 110, 73);
            panel2.Controls.Add(Home_Button);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(AllVegetables_Button);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Welcome_label);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 612);
            panel2.TabIndex = 5;
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
            AllVegetables_Button.Location = new Point(14, 276);
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
            // Welcome_label
            // 
            Welcome_label.AutoSize = true;
            Welcome_label.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome_label.ForeColor = Color.White;
            Welcome_label.Location = new Point(44, 150);
            Welcome_label.Name = "Welcome_label";
            Welcome_label.Size = new Size(200, 26);
            Welcome_label.TabIndex = 30;
            Welcome_label.Text = "Welcome, User!      ";
            Welcome_label.Click += Welcome_label_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button_Delete);
            panel4.Controls.Add(View_Button);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(250, 522);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 126);
            panel4.TabIndex = 14;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(483, 69);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(94, 29);
            button_Delete.TabIndex = 8;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // View_Button
            // 
            View_Button.BackColor = Color.White;
            View_Button.Location = new Point(360, 71);
            View_Button.Name = "View_Button";
            View_Button.Size = new Size(94, 29);
            View_Button.TabIndex = 7;
            View_Button.Text = "View";
            View_Button.UseVisualStyleBackColor = false;
            View_Button.Click += View_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = Color.FromArgb(44, 110, 73);
            dataGridView1.Location = new Point(250, 36);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(899, 612);
            dataGridView1.TabIndex = 13;
            // 
            // Lebel_above_DataGrid
            // 
            Lebel_above_DataGrid.AutoSize = true;
            Lebel_above_DataGrid.Font = new Font("Elephant", 11.999999F);
            Lebel_above_DataGrid.Location = new Point(537, 264);
            Lebel_above_DataGrid.Name = "Lebel_above_DataGrid";
            Lebel_above_DataGrid.Size = new Size(356, 26);
            Lebel_above_DataGrid.TabIndex = 39;
            Lebel_above_DataGrid.Text = "You don`t have your own plants yet\r\n";
            // 
            // UserMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 648);
            Controls.Add(Lebel_above_DataGrid);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserMainPage";
            Text = "UserMainPage";
            Load += UserMainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label allUsers_Label;
        private Label LearnMore_Label;
        private Panel panel2;
        private Button Home_Button;
        private PictureBox pictureBox2;
        private Button AllVegetables_Button;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Welcome_label;
        private Label Lebel_above_DataGrid;
        private Panel panel4;
        private Button View_Button;
        private DataGridView dataGridView1;
        private Button button_Delete;
    }
}