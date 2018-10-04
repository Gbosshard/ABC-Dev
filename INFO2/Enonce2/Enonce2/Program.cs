using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enonce2
{
    class Program
    {
        static void Main(string[] args)
        {
            string beau = null;
            string etatBicyclette = null;
            string repImmediate = null;
            string livreMB = null;

            Console.WriteLine("est-ce qu'il fait beau?(o/n)");
            beau = Console.ReadLine();
            if (beau == "o")
            {
                Console.WriteLine("est-ce que ma biclette est en parfait état de fonctionnement?(o/n)");
                etatBicyclette = Console.ReadLine();
                if (etatBicyclette == "n")
                {
                    Console.WriteLine("je vais chez le garagiste pour faire la réparation de ma bycyclette");
                    Console.WriteLine("est-ce que la réparation est immédiate?(o/n)");
                    repImmediate = Console.ReadLine();
                    if (repImmediate == "o")
                    {
                        Console.WriteLine("ma bicyclette est réparée immédiatement");
                        etatBicyclette = "o";
                    }
                    else
                    {
                        Console.WriteLine("ma bicyclette ne sera pas réparée dans la journée");
                    }
                }
                Console.WriteLine("il fait beau");
                Console.WriteLine("je vais profiter du beau temps");
                if (etatBicyclette == "o")
                {
                    Console.WriteLine("je vais faire un tour de bicyclette");
                }
                else
                {
                    Console.WriteLine("je vais jusqu'à l'étang ceuillir des joncs");
                }

            }
            else
            {
                Console.WriteLine("j'aimerais relire 'Madame Bovary'");
                Console.WriteLine("est-ce que ce livre est dans la bibliotèque du salon?(o/n)");
                livreMB = Console.ReadLine();
                if (livreMB == "n")
                {
                    Console.WriteLine("est-ce que ce livre est à la bibliotèque municipale?(o/n)");
                    livreMB = Console.ReadLine();
                }
                Console.WriteLine("il ne fait pas beau");
                Console.WriteLine("je m'installe confortablement dans mon fauteuil");
                if (livreMB == "o")
                {
                    Console.WriteLine("je lis Madame Bovary");
                }
                else
                {
                    Console.WriteLine("je lis un bouquin policier");
                }
            }
            Console.ReadKey();
        }
    }
}
