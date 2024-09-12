using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (cbClients.SelectedIndex == -1 || numMontant.Value <= 0 || (DateTime.TryParse(dtpDate.Text, out check) && check < DateTime.Now))
            {
                if (cbClients.SelectedIndex == -1)
                {
                    //Ajouter message client
                }
                if (numMontant.Value <= 0)
                {
                    //Ajouter message montant
                }
                if (DateTime.TryParse(dtpDate.Text, out check) && check != DateTime.Now)
                {
                    //Ajouter message date
                }
            }
            else
            {
                //Enregistrer commande dans la BDD
            }
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
