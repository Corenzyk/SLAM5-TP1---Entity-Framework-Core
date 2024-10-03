namespace SLAM5_TP1___Entity_Framework_Core
{
    partial class ListeCdeCli
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
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            btnModifier = new Button();
            btnSuppr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitions2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
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
            dgvPartition.Location = new Point(468, 12);
            dgvPartition.Name = "dgvPartition";
            dgvPartition.Size = new Size(347, 339);
            dgvPartition.TabIndex = 5;
            dgvPartition.Visible = false;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(468, 357);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(347, 23);
            btnAjout.TabIndex = 6;
            btnAjout.Text = "Ajouter une commande";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(821, 12);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(532, 426);
            dgvClients.TabIndex = 7;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(468, 386);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(347, 23);
            btnModifier.TabIndex = 8;
            btnModifier.Text = "Modifier une commande";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSuppr
            // 
            btnSuppr.Location = new Point(468, 415);
            btnSuppr.Name = "btnSuppr";
            btnSuppr.Size = new Size(347, 23);
            btnSuppr.TabIndex = 9;
            btnSuppr.Text = "Supprimer une commande";
            btnSuppr.UseVisualStyleBackColor = true;
            btnSuppr.Click += btnSuppr_Click;
            // 
            // ListeCdeCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 450);
            Controls.Add(btnSuppr);
            Controls.Add(btnModifier);
            Controls.Add(dgvClients);
            Controls.Add(btnAjout);
            Controls.Add(dgvPartition);
            Controls.Add(btnReset);
            Controls.Add(numMontant);
            Controls.Add(cbClients);
            Controls.Add(dgvCommandes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ListeCdeCli";
            Text = "Form1";
            Load += ListeCde_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitions2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
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
        private BindingSource bsClients;
        private DataGridView dgvClients;
        private Button btnModifier;
        private Button btnSuppr;
    }
}