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
            User_dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)User_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // User_dataGridView
            // 
            User_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            User_dataGridView.Location = new Point(29, 28);
            User_dataGridView.Name = "User_dataGridView";
            User_dataGridView.RowHeadersWidth = 51;
            User_dataGridView.Size = new Size(831, 384);
            User_dataGridView.TabIndex = 0;
            // 
            // MainAdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 866);
            Controls.Add(User_dataGridView);
            Name = "MainAdminPage";
            Text = "AdminPage";
           
            ((System.ComponentModel.ISupportInitialize)User_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView User_dataGridView;
    }
}