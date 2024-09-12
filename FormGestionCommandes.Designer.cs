namespace SLAM5_TP1___Entity_Framework_Core
{
    partial class FormGestionCommandes
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
            numMontant = new NumericUpDown();
            dtpDate = new DateTimePicker();
            cbClients = new ComboBox();
            btnValide = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bsClients3 = new BindingSource(components);
            btnAnnule = new Button();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients3).BeginInit();
            SuspendLayout();
            // 
            // numMontant
            // 
            numMontant.Location = new Point(59, 149);
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(270, 23);
            numMontant.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(59, 227);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(270, 23);
            dtpDate.TabIndex = 1;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(59, 306);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(270, 23);
            cbClients.TabIndex = 2;
            // 
            // btnValide
            // 
            btnValide.Location = new Point(95, 374);
            btnValide.Name = "btnValide";
            btnValide.Size = new Size(75, 23);
            btnValide.TabIndex = 3;
            btnValide.Text = "Valider";
            btnValide.UseVisualStyleBackColor = true;
            btnValide.Click += btnValide_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F);
            label1.Location = new Point(75, 55);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 4;
            label1.Text = "Gestion d'une commande";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(59, 133);
            label2.Name = "label2";
            label2.Size = new Size(52, 13);
            label2.TabIndex = 5;
            label2.Text = "Montant :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(59, 211);
            label3.Name = "label3";
            label3.Size = new Size(36, 13);
            label3.TabIndex = 6;
            label3.Text = "Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(59, 290);
            label4.Name = "label4";
            label4.Size = new Size(39, 13);
            label4.TabIndex = 7;
            label4.Text = "Client :";
            // 
            // btnAnnule
            // 
            btnAnnule.Location = new Point(215, 374);
            btnAnnule.Name = "btnAnnule";
            btnAnnule.Size = new Size(75, 23);
            btnAnnule.TabIndex = 8;
            btnAnnule.Text = "Annuler";
            btnAnnule.UseVisualStyleBackColor = true;
            btnAnnule.Click += btnAnnule_Click;
            // 
            // FormGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 409);
            Controls.Add(btnAnnule);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnValide);
            Controls.Add(cbClients);
            Controls.Add(dtpDate);
            Controls.Add(numMontant);
            Name = "FormGestionCommandes";
            Text = "Gestion d'une commande";
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMontant;
        private DateTimePicker dtpDate;
        private ComboBox cbClients;
        private Button btnValide;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private BindingSource bsClients3;
        private Button btnAnnule;
    }
}