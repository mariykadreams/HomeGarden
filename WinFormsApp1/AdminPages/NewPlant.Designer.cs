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
            splitContainer6 = new SplitContainer();
            label7 = new Label();
            comboBox1_Level = new ComboBox();
            splitContainer5 = new SplitContainer();
            label6 = new Label();
            textBox_color = new TextBox();
            splitContainer4 = new SplitContainer();
            label5 = new Label();
            comboBox1_size = new ComboBox();
            splitContainer3 = new SplitContainer();
            label4 = new Label();
            textBox_desciption = new TextBox();
            splitContainer2 = new SplitContainer();
            label3 = new Label();
            comboBox_location = new ComboBox();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            textBox_species = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Type_Label
            // 
            Type_Label.AutoSize = true;
            Type_Label.Location = new Point(499, 20);
            Type_Label.Name = "Type_Label";
            Type_Label.Size = new Size(99, 20);
            Type_Label.TabIndex = 0;
            Type_Label.Text = "Type of plant:";
            // 
            // Vegetable_radioButton
            // 
            Vegetable_radioButton.AutoSize = true;
            Vegetable_radioButton.Location = new Point(365, 75);
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
            Flower_radioButton.Location = new Point(510, 75);
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
            Other_radioButton.Location = new Point(647, 75);
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
            splitContainer.Size = new Size(656, 52);
            splitContainer.SplitterDistance = 272;
            splitContainer.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
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
            textBox_name.Size = new Size(344, 27);
            textBox_name.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer6);
            panel1.Controls.Add(splitContainer5);
            panel1.Controls.Add(splitContainer4);
            panel1.Controls.Add(splitContainer3);
            panel1.Controls.Add(splitContainer2);
            panel1.Controls.Add(splitContainer1);
            panel1.Controls.Add(splitContainer);
            panel1.Location = new Point(57, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 440);
            panel1.TabIndex = 5;
            // 
            // splitContainer6
            // 
            splitContainer6.Location = new Point(12, 365);
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(label7);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(comboBox1_Level);
            splitContainer6.Size = new Size(656, 52);
            splitContainer6.SplitterDistance = 272;
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
            comboBox1_Level.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBox1_Level.Location = new Point(15, 13);
            comboBox1_Level.Name = "comboBox1_Level";
            comboBox1_Level.Size = new Size(224, 28);
            comboBox1_Level.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.Location = new Point(12, 307);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label6);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(textBox_color);
            splitContainer5.Size = new Size(656, 52);
            splitContainer5.SplitterDistance = 272;
            splitContainer5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 0;
            label6.Text = "Color";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_color
            // 
            textBox_color.Location = new Point(15, 12);
            textBox_color.Name = "textBox_color";
            textBox_color.Size = new Size(344, 27);
            textBox_color.TabIndex = 1;
            // 
            // splitContainer4
            // 
            splitContainer4.Location = new Point(12, 249);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label5);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(comboBox1_size);
            splitContainer4.Size = new Size(656, 52);
            splitContainer4.SplitterDistance = 272;
            splitContainer4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 16);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 0;
            label5.Text = "Size";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1_size
            // 
            comboBox1_size.Enabled = false;
            comboBox1_size.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            comboBox1_size.Location = new Point(15, 13);
            comboBox1_size.Name = "comboBox1_size";
            comboBox1_size.Size = new Size(224, 28);
            comboBox1_size.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Location = new Point(12, 191);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox_desciption);
            splitContainer3.Size = new Size(656, 52);
            splitContainer3.SplitterDistance = 272;
            splitContainer3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 0;
            label4.Text = "Short description";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_desciption
            // 
            textBox_desciption.Location = new Point(15, 12);
            textBox_desciption.Name = "textBox_desciption";
            textBox_desciption.Size = new Size(344, 27);
            textBox_desciption.TabIndex = 1;
            textBox_desciption.TextChanged += textBox_desciption_TextChanged;
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
            splitContainer2.Size = new Size(656, 52);
            splitContainer2.SplitterDistance = 272;
            splitContainer2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Location";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_location
            // 
            comboBox_location.FormattingEnabled = true;
            comboBox_location.Items.AddRange(new object[] { "Windowsill (needs a lot of sun)", "Balance between shade and sun", "Shadow" });
            comboBox_location.Location = new Point(15, 12);
            comboBox_location.Name = "comboBox_location";
            comboBox_location.Size = new Size(224, 28);
            comboBox_location.TabIndex = 1;
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
            splitContainer1.Size = new Size(656, 52);
            splitContainer1.SplitterDistance = 272;
            splitContainer1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
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
            textBox_species.Size = new Size(344, 27);
            textBox_species.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(904, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewPlant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 597);
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
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
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
    }
}