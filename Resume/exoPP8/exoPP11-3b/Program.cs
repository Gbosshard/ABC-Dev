using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            string nbs;
            int nb, nbj = 0, nbTot = 0;

            do
            {
                Console.WriteLine("Entrer l'entier ou appuyer sur entrer :");
                nbs = Console.ReadLine();
                if (nbs != "")
                {
                    nbTot++;
                    nb = int.Parse(nbs);
                    if (nb < 20)
                    {
                        nbj++;
                    }
                }
            } while (nbs != "");
            if (nbj == 0)
            {
                Console.WriteLine("Pas de jeunes");
            }
            else
            {
                if (nbj == nbTot)
                {
                    Console.WriteLine("Pas de non jeunes");
                }
                else
                {
                    Console.WriteLine("Des Jeunes et des non jeunes");
                    Console.WriteLine("Il y a {0} jeunes", nbj);
                }
            }
            Console.ReadKey();
        }
    }
}
