namespace UI
{
    partial class AllUsersMiniPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            User_dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)User_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // User_dataGrid
            // 
            User_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            User_dataGrid.Location = new Point(204, 204);
            User_dataGrid.Name = "User_dataGrid";
            User_dataGrid.RowHeadersWidth = 51;
            User_dataGrid.Size = new Size(483, 259);
            User_dataGrid.TabIndex = 0;
            // 
            // AllUsersMiniPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(User_dataGrid);
            Name = "AllUsersMiniPage";
            Size = new Size(899, 612);
            ((System.ComponentModel.ISupportInitialize)User_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView User_dataGrid;
    }
}
