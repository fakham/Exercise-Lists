using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Lists
{
    class Commandes
    {
        private List<Commande> listeCommandes = new List<Commande>();

        public void AjouterCommande(Commande c)
        {
            listeCommandes.Add(c);
        }

        public void SupprimerCommande(int num)
        {
            for (int i = 0; i < listeCommandes.Count; i++)
            {
                if (listeCommandes[i].Numero == num)
                {
                    listeCommandes.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Commande> CommandesClient(string nomClient)
        {
            List<Commande> liste = new List<Commande>();

            foreach (Commande c in listeCommandes)
                if (c.NomClient == nomClient)
                    liste.Add(c);

            return liste;
        }

        public decimal ChiffreAffaire(int annee)
        {
            decimal total = 0M;

            foreach (Commande c in listeCommandes)
                if (c.DateCommande.Year == annee)
                    total += c.PrixCommande();

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Commande c in listeCommandes)
                sb.AppendLine(c.ToString());

            return sb.ToString();
        }
    }
}
