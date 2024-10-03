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

            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet"; // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients2.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbClients.DataSource = bsClients2;
            cbClients.SelectedIndex = -1;

            cbLivreur.ValueMember = "idMoyen";
            cbLivreur.DisplayMember = "nomMoyen";
            bsLivreur.DataSource = (Modele.listeLivreur()).Select(x => new
            {
                x.IdMoyen,
                x.NomMoyen
            });
            cbLivreur.DataSource = bsLivreur;
            cbLivreur.SelectedIndex = -1;

            DataTable dt = new DataTable();

            dt.Columns.Add("idAffichage", typeof(int));
            dt.Columns.Add("nomAffichage");

            DataRow dr1 = dt.NewRow();
            dr1["nomAffichage"] = "Clients";
            dr1["idAffichage"] = 0;
            DataRow dr2 = dt.NewRow();
            dr2["nomAffichage"] = "Partitions";
            dr2["idAffichage"] = 1;
            DataRow dr3 = dt.NewRow();
            dr3["nomAffichage"] = "Styles";
            dr3["idAffichage"] = 2;
            DataRow dr4 = dt.NewRow();
            dr4["nomAffichage"] = "Livreurs";
            dr4["idAffichage"] = 3;

            dt.Rows.InsertAt(dr1, 0);
            dt.Rows.InsertAt(dr2, 1);
            dt.Rows.InsertAt(dr3, 2);
            dt.Rows.InsertAt(dr4, 3);

            cbAffichageDGV.DisplayMember = "nomAffichage";
            cbAffichageDGV.ValueMember = "idAffichage";
            cbAffichageDGV.DataSource = dt;
            cbAffichageDGV.SelectedIndex = -1;
        }

        private void ListeCde_Load(object sender, EventArgs e)
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli,
                //x.IdMoyenNavigation.NomMoyen,
                //x.IdMoyenNavigation.DescMoyen
            });  // appel de la méthode listeClients
            dgvCommandes.DataSource = bsCommandes;
        }

        private void bsClients2_CurrentChanged_1(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli,
                //x.IdMoyenNavigation.NomMoyen,
                //x.IdMoyenNavigation.DescMoyen
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
                x.NumcliNavigation.Prenomcli,
                //x.IdMoyenNavigation.NomMoyen,
                //x.IdMoyenNavigation.DescMoyen
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
                x.NumcliNavigation.Prenomcli,
                //x.IdMoyenNavigation.NomMoyen,
                //x.IdMoyenNavigation.DescMoyen
            });
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
            FormGestionCommandes gestion = new FormGestionCommandes(0);
            gestion.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommandes.Current.GetType();
            int idCommande = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);
            this.Hide();
            FormGestionCommandes gestion = new FormGestionCommandes(idCommande);
            gestion.Show();
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommandes.Current.GetType();
            int idCommande = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);
            if (MessageBox.Show("Etes vous sur de vouloir supprimer la commande :" + idCommande, "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Modele.SuppCommande(idCommande);
                bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
                {
                    x.Numcde,
                    x.Montantcde,
                    x.Datecde,
                    x.NumcliNavigation.Nomcli,
                    x.NumcliNavigation.Prenomcli,
                    //x.IdMoyenNavigation.NomMoyen,
                    //x.IdMoyenNavigation.DescMoyen
                });
                dgvCommandes.DataSource = bsCommandes;
            }
        }

        private void bsLivreur_CurrentChanged(object sender, EventArgs e)
        {
            int idLivreur = Convert.ToInt32(cbLivreur.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParLivreur(idLivreur).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli,
                //x.IdMoyenNavigation.NomMoyen,
                //x.IdMoyenNavigation.DescMoyen
            });
            dgvCommandes.DataSource = bsCommandes;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAffichageDGV.SelectedIndex == 3)
            {
                bsLivreur2.DataSource = Modele.listeLivreur().Select(x => new
                {
                    x.IdMoyen,
                    x.NomMoyen,
                    x.DescMoyen
                });
                dgvAffichage.DataSource = bsLivreur2;
            }
        }

        /*
         * Mission 1 :
         * Dans l'affichage des commandes :
         * - ajout de la colonne du moyen de livraison (si aucun, valeur par défaut "retrait en magasin")
         * 
         * Mission 3 :
         * Ajout d'un bouton permettant de faire apparaitre les modes de livraison sur la dgv de droite
         * Quand la DGV de droite affiche les modes de livraisons, affiché un bouton "Supprimer le mode de livraison"
         * Le bouton demandera la confirmation pour supprimer le mode de livraison selectionné, affichera aucun mode selectionné sinon
         * Si le mode de livraison est supprimé, recharger la BS
         */
    }
}
