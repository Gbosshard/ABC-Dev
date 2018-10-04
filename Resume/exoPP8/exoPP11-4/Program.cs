using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int random, nb, lmin = 0, lmax = 100;
            Random rnd = new Random();
            random = rnd.Next(lmin, lmax + 1);
            do
            {
                Console.WriteLine("miser sur un nombre entre {0} et {1}: ", lmin , lmax);
                nb = int.Parse(Console.ReadLine());

                if (nb < random)
                {
                    lmin = nb;
                }
                else
                {
                    lmax = nb;
                }
            } while (nb != random);
            Console.WriteLine("Gagné!");
            Console.ReadKey();
        }
    }
}
