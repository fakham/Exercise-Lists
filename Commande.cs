using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Lists
{
    class Commande
    {
        private int numero;
        private DateTime dateCommande;
        private string nomClient;
        private List<Produit> listeProduits;

        public Commande()
        {
            this.listeProduits = new List<Produit>();
        }

        public Commande(int numero, DateTime dateCommande, string nomClient) : this()
        {
            this.Numero = numero;
            this.DateCommande = dateCommande;
            this.NomClient = nomClient;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }

        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }

        public List<Produit> ListeProduits
        {
            get { return listeProduits; }
            set { listeProduits = value; }
        }

        public Produit ChercherProduit(string reference)
        {
            Produit p = null;

            foreach (Produit pr in listeProduits)
            {
                if (pr.Reference == reference)
                {
                    p = pr;
                    break;
                }
            }

            return p;
        }

        public int IndiceProduit(string reference)
        {
            int indice = -1;

            for (int i = 0; i < listeProduits.Count; i++)
            {
                if (listeProduits[i].Reference == reference)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public void AjouterProduit(Produit p)
        {
            if (ChercherProduit(p.Reference) == null)
                listeProduits.Add(p);
        }

        public void AjouterProduit(string reference, string description, decimal prix)
        {
            if (ChercherProduit(reference) == null)
            { 
                listeProduits.Add(new Produit(reference, description, prix);
            }
        }

        public void SupprimerProduit(string reference)
        {
            Produit p = ChercherProduit(reference);

            if (p != null)
                listeProduits.Remove(p);
        }

        public decimal PrixCommande()
        {
            decimal total = 0M;

            foreach (Produit p in listeProduits)
                total += p.Prix;

            return total;
        }

        public int NombreProduitsCommande()
        {
            return listeProduits.Count;
        }

        public List<Produit> ProduitPrix(decimal prixMin, decimal prixMax)
        {
            List<Produit> liste = new List<Produit>();

            foreach (Produit p in listeProduits)
            {
                if (p.Prix >= prixMin && p.Prix <= prixMax)
                    liste.Add(p);
            }

            return liste;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            string header = string.Format("Numero : {0}, Date : {1}, Nom Client : {2}", this.numero, this.dateCommande, this.nomClient);
            
            sb.AppendLine(header);
            sb.AppendLine("Liste Produits : ");

            foreach (Produit p in listeProduits)
                sb.AppendLine(p.ToString());

            return sb.ToString();
        }
    }
}
