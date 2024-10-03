using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Update;
using SLAM5_TP1___Entity_Framework_Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SLAM5_TP1___Entity_Framework_Core
{
    public partial class FormGestionCommandes : Form
    {
        public FormGestionCommandes(int idCommande)
        {
            InitializeComponent();
            label1.Text = "Ajout d'une commande";
            label5.Visible = false;
            label6.Visible = false;
            cbClients.SelectedIndex = -1;
            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet"; // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients3.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbClients.DataSource = bsClients3;
            List<Partition> lesP = new(Modele.listePartitions());
            foreach (Partition P in lesP)
            {
                checkLPartitions.Items.Add(P.Libpart);
            }
            if (idCommande != 0)
            {
                label1.Text = "Modification d'une commande";
                label5.Visible = true;
                label6.Visible = true;
                label6.Text = Convert.ToString(idCommande);
                Commande cde = Modele.RecupererCommande(idCommande);
                cbClients.SelectedIndex = cde.Numcli-1;
                numMontant.Value = Convert.ToDecimal(cde.Montantcde);
                dtpDate.Value = Convert.ToDateTime(cde.Datecde);
            }
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            DateTime check;
            string message="";
            if (cbClients.SelectedIndex == -1 || numMontant.Value <= 0 || (DateTime.TryParse(dtpDate.Text, out check) && check > DateTime.Now))
            {
                if (cbClients.SelectedIndex == -1)
                {
                    message += "\n Le client n'a pas été renseigné";
                }
                if (numMontant.Value <= 0)
                {
                    message += "\n Le montant n'est pas valide";
                }
                if (DateTime.TryParse(dtpDate.Text, out check) && check > DateTime.Now)
                {
                    message += "\n La date ne convient pas (dans le futur)";
                }
                MessageBox.Show("Des erreurs ont été detecté :"+message);
            }
            else
            {
                if (label1.Text == "Ajout d'une commande")
                {
                    if (Modele.AjoutCommande(Convert.ToInt32(numMontant.Value), dtpDate.Value, Convert.ToInt32(cbClients.SelectedValue)))
                    {
                        MessageBox.Show("Enregistrement réussi");
                        cbClients.SelectedIndex = -1;
                        numMontant.Value = 0;
                        dtpDate.Value = DateTime.Now;
                        checkLPartitions.SelectedItems.Clear();
                    }
                }
                else
                {
                    if (Modele.ModifierCommande(Convert.ToInt32(label6.Text), Convert.ToInt32(numMontant.Value), dtpDate.Value, Convert.ToInt32(cbClients.SelectedValue)))
                    {
                        MessageBox.Show("Enregistrement réussi");
                        cbClients.SelectedIndex = -1;
                        numMontant.Value = 0;
                        dtpDate.Value = DateTime.Now;
                        label1.Text = "Ajout d'une commande";
                        label5.Visible = false;
                        label6.Visible = false;
                        checkLPartitions.SelectedItems.Clear();
                    }
                }
            }
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeCdeCli commande = new ListeCdeCli();
            commande.Show();
        }
    }
}
