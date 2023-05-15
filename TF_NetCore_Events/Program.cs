namespace TF_NetCore_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produit produit = new Produit("NASDAQ")
            {
                Prix = 13_340.17
            };

            Produit produit2 = new Produit("BEL20")
            {
                Prix = 3_744.95
            };

            Trader koumeil = new Trader("Koumeil");
            Trader elody = new Trader("Elody");

            produit.NotifyHandler += koumeil.Reagir;
            produit.NotifyHandler += elody.Reagir;

            produit.Prix = 13_341.19;

            Console.ForegroundColor
        }
    }
}