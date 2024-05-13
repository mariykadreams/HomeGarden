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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminPage));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            AllVegetables_Button = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SignUp_Button = new Button();
            Welcome_label = new Label();
            panel3 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            allUsersMiniPage1 = new AllUsersMiniPage();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 110, 73);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 36);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 110, 73);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(AllVegetables_Button);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(SignUp_Button);
            panel2.Controls.Add(Welcome_label);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 612);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
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
            AllVegetables_Button.Location = new Point(14, 293);
            AllVegetables_Button.Margin = new Padding(3, 4, 3, 4);
            AllVegetables_Button.Name = "AllVegetables_Button";
            AllVegetables_Button.Size = new Size(200, 40);
            AllVegetables_Button.TabIndex = 36;
            AllVegetables_Button.Text = "All Vegetables";
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
            label1.Font = new Font("Sitka Subheading", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 567);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 33;
            label1.Text = "Sign Out";
            label1.Click += label1_Click;
            // 
            // SignUp_Button
            // 
            SignUp_Button.BackColor = Color.FromArgb(44, 110, 73);
            SignUp_Button.Cursor = Cursors.Hand;
            SignUp_Button.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_Button.ForeColor = Color.White;
            SignUp_Button.Location = new Point(14, 232);
            SignUp_Button.Margin = new Padding(3, 4, 3, 4);
            SignUp_Button.Name = "SignUp_Button";
            SignUp_Button.Size = new Size(200, 40);
            SignUp_Button.TabIndex = 32;
            SignUp_Button.Text = "All Users";
            SignUp_Button.UseVisualStyleBackColor = false;
            SignUp_Button.Click += SignUp_Button_Click;
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
            panel3.Controls.Add(allUsersMiniPage1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 612);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // allUsersMiniPage1
            // 
            allUsersMiniPage1.Location = new Point(0, 0);
            allUsersMiniPage1.Name = "allUsersMiniPage1";
            allUsersMiniPage1.Size = new Size(1124, 765);
            allUsersMiniPage1.TabIndex = 0;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label Welcome_label;
        private Label label1;
        private Button SignUp_Button;
        private PictureBox pictureBox1;
        private Button AllVegetables_Button;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private AllUsersMiniPage allUsersMiniPage1;
    }
}