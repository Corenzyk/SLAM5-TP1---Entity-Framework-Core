namespace SLAM5_TP1___Entity_Framework_Core
{
    partial class ListeCde
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
            components = new System.ComponentModel.Container();
            dgvCommandes = new DataGridView();
            bsCommandes = new BindingSource(components);
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            numMontant = new NumericUpDown();
            btnReset = new Button();
            dgvPartition = new DataGridView();
            bsPartitions2 = new BindingSource(components);
            btnAjout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitions2).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommandes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommandes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(12, 70);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.Size = new Size(450, 368);
            dgvCommandes.TabIndex = 1;
            dgvCommandes.CellMouseClick += dgvCommandes_CellMouseClick;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(12, 12);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(450, 23);
            cbClients.TabIndex = 2;
            // 
            // bsClients2
            // 
            bsClients2.CurrentChanged += bsClients2_CurrentChanged_1;
            // 
            // numMontant
            // 
            numMontant.Location = new Point(12, 41);
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(212, 23);
            numMontant.TabIndex = 3;
            numMontant.ValueChanged += numMontant_ValueChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(387, 41);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reinitialiser";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvPartition
            // 
            dgvPartition.AllowUserToAddRows = false;
            dgvPartition.AllowUserToDeleteRows = false;
            dgvPartition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPartition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPartition.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPartition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartition.Location = new Point(468, 304);
            dgvPartition.Name = "dgvPartition";
            dgvPartition.Size = new Size(320, 134);
            dgvPartition.TabIndex = 5;
            dgvPartition.Visible = false;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(628, 12);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(160, 23);
            btnAjout.TabIndex = 6;
            btnAjout.Text = "Ajouter une commande";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // ListeCde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAjout);
            Controls.Add(dgvPartition);
            Controls.Add(btnReset);
            Controls.Add(numMontant);
            Controls.Add(cbClients);
            Controls.Add(dgvCommandes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListeCde";
            Text = "Form1";
            Load += ListeCde_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitions2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private NumericUpDown numMontant;
        private Button btnReset;
        private DataGridView dgvPartition;
        private BindingSource bsPartitions2;
        private Button btnAjout;
    }
}