using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbo, nbj, pto = 0, ptj = 0;
            Random rnd = new Random();
            bool good;
            do
            {
                Console.WriteLine("Miser sur un chiffre entre 0 et 2");
                
                good = int.TryParse(Console.ReadLine(), out nbj);
                nbo = rnd.Next(3);
                Console.WriteLine("la machine à joué : {0}", nbo);

                switch (Math.Abs(nbo - nbj))
                {
                    case 1:
                        if (nbo > nbj)
                        {
                            ptj++;
                        }
                        else
                        {
                            pto++;
                        }
                        break;
                    case 2:
                        if (nbo > nbj)
                        {
                            pto++;
                        }
                        else
                        {
                            ptj++;
                        }
                        break;
                    default:
                        break;

                }
            } while ((nbj >= 0) && (pto < 10) && (ptj < 10));
            Console.WriteLine("Score : ordi {0}, humain {1}", pto, ptj);
            if (pto < ptj)
            {
                Console.WriteLine("Avantages joueur");
            }
            else
            {
                Console.WriteLine("Avantages machine");
            }
            if (nbj < 0)
            {
                Console.WriteLine("Mais partie non terminer");
            }
            else
            {
                Console.WriteLine("Misère !!");
            }
            Console.ReadKey();
        }
    }
}
