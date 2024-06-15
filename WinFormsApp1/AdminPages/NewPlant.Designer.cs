namespace UI.AdminPages
{
    partial class NewPlant
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
            Type_Label = new Label();
            Vegetable_radioButton = new RadioButton();
            Flower_radioButton = new RadioButton();
            Other_radioButton = new RadioButton();
            splitContainer = new SplitContainer();
            label1 = new Label();
            textBox_name = new TextBox();
            panel1 = new Panel();
            splitContainer7 = new SplitContainer();
            label8 = new Label();
            numericUpDown_Water = new NumericUpDown();
            splitContainer6 = new SplitContainer();
            label7 = new Label();
            comboBox1_Level = new ComboBox();
            splitContainer5 = new SplitContainer();
            label6 = new Label();
            textBox_color = new TextBox();
            splitContainer3 = new SplitContainer();
            label4 = new Label();
            textBox_desciption = new TextBox();
            splitContainer2 = new SplitContainer();
            label3 = new Label();
            comboBox_location = new ComboBox();
            splitContainer4 = new SplitContainer();
            label5 = new Label();
            comboBox1_size = new ComboBox();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            textBox_species = new TextBox();
            button1 = new Button();
            Cencel_button = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Water).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Type_Label
            // 
            Type_Label.AutoSize = true;
            Type_Label.Font = new Font("Elephant", 11.999999F);
            Type_Label.Location = new Point(374, 51);
            Type_Label.Name = "Type_Label";
            Type_Label.Size = new Size(147, 26);
            Type_Label.TabIndex = 0;
            Type_Label.Text = "Type of plant:";
            Type_Label.Click += Type_Label_Click;
            // 
            // Vegetable_radioButton
            // 
            Vegetable_radioButton.AutoSize = true;
            Vegetable_radioButton.Location = new Point(264, 115);
            Vegetable_radioButton.Name = "Vegetable_radioButton";
            Vegetable_radioButton.Size = new Size(97, 24);
            Vegetable_radioButton.TabIndex = 1;
            Vegetable_radioButton.TabStop = true;
            Vegetable_radioButton.Text = "Vegetable";
            Vegetable_radioButton.UseVisualStyleBackColor = true;
            Vegetable_radioButton.CheckedChanged += Vegetable_radioButton_CheckedChanged;
            // 
            // Flower_radioButton
            // 
            Flower_radioButton.AutoSize = true;
            Flower_radioButton.Location = new Point(409, 115);
            Flower_radioButton.Name = "Flower_radioButton";
            Flower_radioButton.Size = new Size(74, 24);
            Flower_radioButton.TabIndex = 2;
            Flower_radioButton.TabStop = true;
            Flower_radioButton.Text = "Flower";
            Flower_radioButton.UseVisualStyleBackColor = true;
            Flower_radioButton.CheckedChanged += Flower_radioButton_CheckedChanged;
            // 
            // Other_radioButton
            // 
            Other_radioButton.AutoSize = true;
            Other_radioButton.Location = new Point(546, 115);
            Other_radioButton.Name = "Other_radioButton";
            Other_radioButton.Size = new Size(67, 24);
            Other_radioButton.TabIndex = 4;
            Other_radioButton.TabStop = true;
            Other_radioButton.Text = "Other";
            Other_radioButton.UseVisualStyleBackColor = true;
            Other_radioButton.CheckedChanged += Other_radioButton_CheckedChanged;
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(12, 17);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(label1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(textBox_name);
            splitContainer.Size = new Size(300, 52);
            splitContainer.SplitterDistance = 74;
            splitContainer.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(15, 15);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(198, 27);
            textBox_name.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer7);
            panel1.Controls.Add(splitContainer6);
            panel1.Controls.Add(splitContainer5);
            panel1.Controls.Add(splitContainer3);
            panel1.Controls.Add(splitContainer2);
            panel1.Controls.Add(splitContainer4);
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(splitContainer);
            panel1.Location = new Point(106, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 367);
            panel1.TabIndex = 5;
            // 
            // splitContainer7
            // 
            splitContainer7.Location = new Point(356, 17);
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(label8);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(numericUpDown_Water);
            splitContainer7.Size = new Size(300, 52);
            splitContainer7.SplitterDistance = 74;
            splitContainer7.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 15);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 0;
            label8.Text = "Water";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Water
            // 
            numericUpDown_Water.Location = new Point(14, 13);
            numericUpDown_Water.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_Water.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Water.Name = "numericUpDown_Water";
            numericUpDown_Water.Size = new Size(150, 27);
            numericUpDown_Water.TabIndex = 0;
            numericUpDown_Water.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // splitContainer6
            // 
            splitContainer6.Location = new Point(12, 191);
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(label7);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(comboBox1_Level);
            splitContainer6.Size = new Size(300, 52);
            splitContainer6.SplitterDistance = 77;
            splitContainer6.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 16);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 0;
            label7.Text = "Level";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1_Level
            // 
            comboBox1_Level.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_Level.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBox1_Level.Location = new Point(15, 13);
            comboBox1_Level.Name = "comboBox1_Level";
            comboBox1_Level.Size = new Size(195, 28);
            comboBox1_Level.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.Location = new Point(356, 133);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label6);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(textBox_color);
            splitContainer5.Size = new Size(300, 52);
            splitContainer5.SplitterDistance = 55;
            splitContainer5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 0;
            label6.Text = "Color";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_color
            // 
            textBox_color.Location = new Point(8, 13);
            textBox_color.Name = "textBox_color";
            textBox_color.Size = new Size(224, 27);
            textBox_color.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Location = new Point(12, 249);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox_desciption);
            splitContainer3.Size = new Size(644, 115);
            splitContainer3.SplitterDistance = 180;
            splitContainer3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Description";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_desciption
            // 
            textBox_desciption.Location = new Point(3, 3);
            textBox_desciption.Multiline = true;
            textBox_desciption.Name = "textBox_desciption";
            textBox_desciption.Size = new Size(445, 100);
            textBox_desciption.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(12, 133);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(comboBox_location);
            splitContainer2.Size = new Size(300, 52);
            splitContainer2.SplitterDistance = 75;
            splitContainer2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Location";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_location
            // 
            comboBox_location.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_location.FormattingEnabled = true;
            comboBox_location.Items.AddRange(new object[] { "Windowsill (needs a lot of sun)", "Balance between shade and sun", "Shadow" });
            comboBox_location.Location = new Point(14, 15);
            comboBox_location.Name = "comboBox_location";
            comboBox_location.Size = new Size(198, 28);
            comboBox_location.TabIndex = 1;
            // 
            // splitContainer4
            // 
            splitContainer4.Location = new Point(356, 75);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label5);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(comboBox1_size);
            splitContainer4.Size = new Size(300, 52);
            splitContainer4.SplitterDistance = 54;
            splitContainer4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 0;
            label5.Text = "Size";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1_size
            // 
            comboBox1_size.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_size.Enabled = false;
            comboBox1_size.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            comboBox1_size.Location = new Point(9, 13);
            comboBox1_size.Name = "comboBox1_size";
            comboBox1_size.Size = new Size(224, 28);
            comboBox1_size.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 75);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBox_species);
            splitContainer1.Size = new Size(300, 52);
            splitContainer1.SplitterDistance = 74;
            splitContainer1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 15);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Species";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_species
            // 
            textBox_species.Location = new Point(15, 12);
            textBox_species.Name = "textBox_species";
            textBox_species.Size = new Size(198, 27);
            textBox_species.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 110, 73);
            button1.Font = new Font("Elephant", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(235, 560);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Cencel_button
            // 
            Cencel_button.BackColor = Color.FromArgb(44, 110, 73);
            Cencel_button.Font = new Font("Elephant", 9F, FontStyle.Bold);
            Cencel_button.ForeColor = Color.White;
            Cencel_button.Location = new Point(506, 560);
            Cencel_button.Name = "Cencel_button";
            Cencel_button.Size = new Size(150, 50);
            Cencel_button.TabIndex = 7;
            Cencel_button.Text = "Cancel";
            Cencel_button.UseVisualStyleBackColor = false;
            Cencel_button.Click += Cencel_button_Click;
            // 
            // NewPlant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 630);
            Controls.Add(Cencel_button);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(Other_radioButton);
            Controls.Add(Flower_radioButton);
            Controls.Add(Vegetable_radioButton);
            Controls.Add(Type_Label);
            Name = "NewPlant";
            Text = "NewVegetable";
            Load += NewPlant_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel1.PerformLayout();
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Water).EndInit();
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel1.PerformLayout();
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Type_Label;
        private RadioButton Vegetable_radioButton;
        private RadioButton Flower_radioButton;
        private RadioButton Other_radioButton;
        private SplitContainer splitContainer;
        private Label label1;
        private Panel panel1;
        private TextBox textBox_name;
        private SplitContainer splitContainer1;
        private Label label2;
        private TextBox textBox_species;
        private SplitContainer splitContainer2;
        private Label label3;
        private SplitContainer splitContainer3;
        private Label label4;
        private TextBox textBox_desciption;
        private SplitContainer splitContainer4;
        private Label label5;
        private ComboBox comboBox1_size;
        private ComboBox comboBox_location;
        private SplitContainer splitContainer5;
        private Label label6;
        private TextBox textBox_color;
        private Button button1;
        private SplitContainer splitContainer6;
        private Label label7;
        private ComboBox comboBox1_Level;
        private SplitContainer splitContainer7;
        private Label label8;
        private NumericUpDown numericUpDown_Water;
        private Button Cencel_button;
    }
}