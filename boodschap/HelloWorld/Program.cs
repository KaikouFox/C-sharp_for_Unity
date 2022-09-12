using System;

namespace Boodschappen
{
    class Program
    {
        const float prijsExclBtw = 59.99f;
        const float btwPercentage = 0.21f;
        static void Main(string[] args)
        {
            const string product = "super mario oddesey";
            int aantal;
            int stock = 60;

            Console.WriteLine("Een " + product + " spel, kost " + prijsExclBtw + " ex btw.");
            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            if (aantal > stock)
            {
                Console.WriteLine("Sorry, we hebben niet zo veel");
            }
            else
            {             
                Console.WriteLine(aantal + " pakken " + product + " kost in totaal " + BTW(aantal));
            }
        }

        public static float BTW(int aantal)
        {
            return aantal * prijsExclBtw + (aantal * prijsExclBtw) * btwPercentage;
        }
    }
}