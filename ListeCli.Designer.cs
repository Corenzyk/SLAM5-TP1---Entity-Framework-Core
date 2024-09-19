namespace SLAM5_TP1___Entity_Framework_Core
{
    partial class ListeCli
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Enabled = false;
            dgvClients.Location = new Point(12, 12);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(776, 426);
            dgvClients.TabIndex = 0;
            // 
            // ListeCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClients);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListeCli";
            Text = "Form1";
            Load += ListeCli_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
    }
}
