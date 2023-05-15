using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_NetCore_Events
{
    internal class Trader
    {
        public string Nom { get; init; }

        public Trader(string nom)
        {
            Nom = nom;
        }

        public void Reagir(Produit produit)
        {            
            Console.WriteLine($"{Nom} recoit l'information que le prix du produit {produit.Nom} à changé pour {produit.Prix}");
        }
    }
}
