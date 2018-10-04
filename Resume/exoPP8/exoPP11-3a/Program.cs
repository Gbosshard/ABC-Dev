using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            string nbs;
            int nb, nbj = 0;

            do
            {
                Console.WriteLine("Entrer l'entier ou appuyer sur entrer :");
                nbs = Console.ReadLine();
                if (nbs != "")
                {
                    nb = int.Parse(nbs);
                    if (nb < 20)
                    {
                        nbj++;
                    }
                }
           } while (nbs != "");
            Console.WriteLine("Il y a {0} jeunes", nbj);
            Console.ReadKey();
        }
    }
}
