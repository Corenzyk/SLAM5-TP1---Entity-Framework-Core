using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SLAM5_TP1___Entity_Framework_Core.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SLAM5_TP1___Entity_Framework_Core
{
    public static class Modele
    {
        private static KuczykCorentinSlam5Tp1Context monModel;

        public static void init()
        {
            monModel = new KuczykCorentinSlam5Tp1Context();
        }
        
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }

        public static List<MoyenLivraison> listeLivreur()
        {
            return monModel.MoyenLivraisons.ToList();
        }

        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).Include(a => a.IdMoyenNavigation).ToList();
        }

        public static List<Partition> listePartitions()
        {
            return monModel.Partitions.ToList();
        }

        public static List<Partition> listePartitionsParCommandes(int idC)
        {
            Commande c = Modele.monModel.Commandes.Include(p => p.Numparts).ThenInclude(p => p.NumstyleNavigation).First(x => x.Numcde == idC);

            List<Partition> lesP = c.Numparts.ToList();

            return lesP;
        }

        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).Include(b => b.IdMoyenNavigation).ToList();
            return lesCommandes;
        }

        public static List<Commande> listeCommandesParLivreur(int idLivreur)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.IdMoyen ==
           idLivreur).Include(p => p.IdMoyenNavigation).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Commande> listeCommandesParMontant(int montant)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Montantcde >=
           montant).Include(p => p.NumcliNavigation).Include(b => b.IdMoyenNavigation).ToList();
            return lesCommandes;
        }

        public static Commande RecupererCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = monModel.Commandes.Include(c => c.Numparts).First(x => x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }

        public static ICollection<Partition> listePartitionsParCommande(int idC)
        {
            Commande maCommande = RecupererCommande(idC);
            ICollection<Partition> part = new List<Partition>();
            part = maCommande.Numparts;
            return part;
        }


        public static bool AjoutCommande(int montant, DateTime dateC, int idClient, int idLivreur)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = System.DateOnly.FromDateTime(dateC); // la propriété DateCde doit être en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                maCommande.IdMoyen = idLivreur;

                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show("Échec de l'ajout");
            }
            return vretour;
        }

        public static bool ModifierCommande(int idCde, int montant, DateTime dateC, int idClient, int idLivreur)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = RecupererCommande(idCde);

                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = System.DateOnly.FromDateTime(dateC); // la propriété DateCde doit être en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;
                maCommande.IdMoyen = idLivreur;

                // ajout de l’objet : correspond à un insert
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show("Échec de la modification");
            }
            return vretour;
        }

        public static bool SuppCommande(int idCommande)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = RecupererCommande(idCommande);
                monModel.Commandes.Remove(maCommande); // correspond au DELETE
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                vretour = false;
                MessageBox.Show("Échec de la suppression");
            }
            return vretour;
        }
    }
}
