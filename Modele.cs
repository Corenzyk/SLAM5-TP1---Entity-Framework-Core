using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SLAM5_TP1___Entity_Framework_Core.Entities;

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
    }
}
