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

        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }

        public static List<Partition> listePartitionsParCommandes(int idC)
        {
            Commande c = Modele.monModel.Commandes.Include(p => p.Numparts).ThenInclude(p => p.NumstyleNavigation).First(x => x.Numcde == idC);
            //ThenInclude = récupération par cascade
            List<Partition> lesP = c.Numparts.ToList();

            return lesP;
        }

        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static List<Commande> listeCommandesParMontant(int montant)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Montantcde >=
           montant).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = System.DateOnly.FromDateTime(dateC); // la propriété DateCde doit être en DateTime dans la BD et dans la classe Commande, modifier si besoin.
                maCommande.Numcli = idClient;

                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

    }
}
