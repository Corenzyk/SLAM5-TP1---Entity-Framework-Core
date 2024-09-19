using SLAM5_TP1___Entity_Framework_Core.Entities;
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
    public partial class ListeCdeCli : Form
    {
        public ListeCdeCli()
        {
            InitializeComponent();
            cbClients.SelectedIndex = -1;
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
            bsClients.DataSource = Modele.listeClients().Select(x => new
            {
                x.Numcli,
                x.Nomcli,
                x.Prenomcli,
                x.Adrcli,
                x.Tel
            }); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
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
            bsCommandes.DataSource = Modele.listeCommandesParMontant(montant).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            }).OrderBy(x => x.Montantcde);
            dgvCommandes.DataSource = bsCommandes;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            }).OrderBy(x => x.Datecde); ;  // appel de la méthode listeClients
            dgvCommandes.DataSource = bsCommandes;
            numMontant.Value = 0;
            cbClients.SelectedIndex = -1;
        }

        private void dgvCommandes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Type type = bsCommandes.Current.GetType();
                int numC = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);

                List<Partition> lesPartitions = Modele.listePartitionsParCommandes(numC);
                if (lesPartitions.Count != 0)
                {
                    bsPartitions2.DataSource = lesPartitions.Select(x => new
                    {
                        x.Numpart,
                        x.Libpart,
                        x.NumstyleNavigation.Libstyle
                    }).OrderBy(x => x.Libstyle); ;

                    dgvPartition.DataSource = bsPartitions2;
                    dgvPartition.Visible = true;

                }
                else
                {
                    dgvPartition.Visible = false;
                    MessageBox.Show("Pas de partitions pour cette commande");
                }
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionCommandes gestion = new FormGestionCommandes();
            gestion.Show();
        }
    }
}
