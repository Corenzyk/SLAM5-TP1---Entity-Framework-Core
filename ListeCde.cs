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
    public partial class ListeCde : Form
    {
        public ListeCde()
        {
            InitializeComponent();
            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet"; // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients2.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbClients.DataSource = bsClients2;

        }

        private void ListeCde_Load(object sender, EventArgs e)
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });  // appel de la méthode listeClients
            dgvCommandes.DataSource = bsCommandes;
        }

        private void bsClients2_CurrentChanged_1(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IDC = Convert.ToInt32(cbClients.SelectedValue);
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            }).OrderBy(x => x.Datecde);
            dgvCommandes.DataSource = bsCommandes;
        }

        private void numMontant_ValueChanged(object sender, EventArgs e)
        {
            int montant = Convert.ToInt32(numMontant.Value);
            bsCommandes.DataSource = Modele.listeCommandesParClient(montant).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            }).OrderBy(x => x.Montantcde);
            dgvCommandes.DataSource = bsCommandes;
        }
    }
}
