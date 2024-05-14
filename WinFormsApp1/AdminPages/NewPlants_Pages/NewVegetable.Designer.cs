namespace UI.AdminPages
{
    partial class NewVegetable
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
            panel1 = new Panel();
            NewVegetable_Label = new Label();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(49, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 445);
            panel1.TabIndex = 0;
            // 
            // NewVegetable_Label
            // 
            NewVegetable_Label.AutoSize = true;
            NewVegetable_Label.Location = new Point(411, 36);
            NewVegetable_Label.Name = "NewVegetable_Label";
            NewVegetable_Label.Size = new Size(109, 20);
            NewVegetable_Label.TabIndex = 1;
            NewVegetable_Label.Text = "New vegetable";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(49, 152);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(656, 52);
            splitContainer1.SplitterDistance = 272;
            splitContainer1.TabIndex = 2;
            // 
            // NewVegetable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 699);
            Controls.Add(splitContainer1);
            Controls.Add(NewVegetable_Label);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewVegetable";
            Text = "NewVegetable";
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label NewVegetable_Label;
        private SplitContainer splitContainer1;
    }
}