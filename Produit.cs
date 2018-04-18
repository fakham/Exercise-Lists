using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Lists
{
    class Produit
    {
        private string reference;
        private string description;
        private decimal prix;

        public Produit()
        { }

        public Produit(string reference, string description, decimal prix)
        {
            this.Reference = reference;
            this.Description = description;
            this.Prix = prix;
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public override string ToString()
        {
            return string.Format("Ref : {0}, Description : {1}, Prix : {2}DH", this.Reference, this.Description, this.Prix);
        }
    }
}
