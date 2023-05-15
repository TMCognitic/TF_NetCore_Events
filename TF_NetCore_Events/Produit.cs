using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_NetCore_Events
{
    internal class Produit
    {
		public event ProduitHandler? NotifyHandler;

        public string Nom { get; init; }
        private double _prix;

		public double Prix
		{
			get { return _prix; }
			set 
			{ 
				if(_prix != value)
				{
					_prix = value;
					Raise();
				}
			}
		}        

        public Produit(string nom)
        {
            Nom = nom;
        }

		protected void Raise()
		{
            NotifyHandler?.Invoke(this);
        }
	}
}
