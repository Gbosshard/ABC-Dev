using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int solde,nb = 0;
            Console.WriteLine("Combien avait Barnabé au départ? (en franc)");
            solde = int.Parse(Console.ReadLine());

            while (solde > 1)
            {
                nb++;
                Console.WriteLine("{0} magasin : {1:#,###} franc", nb, (solde/2 + 1));
                solde -= solde / 2 + 1;
            }
            if (solde != 0)
            {
                nb++;
                Console.WriteLine("dernier magasin : {0} franc", solde);
                solde = 0;
            }
            Console.WriteLine("nombre de magasin où Barnabé à acheté : {0}", nb);
            Console.ReadKey();
        }
    }
}
