using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SLAM5_TP1___Entity_Framework_Core
{
    public partial class FormGestionCommandes : Form
    {
        public FormGestionCommandes()
        {
            InitializeComponent();
            cbClients.SelectedIndex = -1;
            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet"; // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients3.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbClients.DataSource = bsClients3;
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
                if (Modele.AjoutCommande(Convert.ToInt32(numMontant.Value), dtpDate.Value, Convert.ToInt32(cbClients.SelectedValue)))
                {
                    MessageBox.Show("Enregistrement réussi");
                }
                else
                {
                    MessageBox.Show("L'enregistrement à échoué");
                }
            }
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeCde commande = new ListeCde();
            commande.Show();
        }
    }
}
