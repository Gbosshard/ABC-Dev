using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            Random rand = new Random();
            int i , n = 0;
            int x;
            bool res = false;

            // faire un tableau en ordre croissant
            for (i = 0; i < 10; i++)
            {
                n += rand.Next(1,3);
                tab[i] = n;
                Console.Write(" " +n+ " ");
            }

            Console.WriteLine("entrez un entier x :");
            x = int.Parse(Console.ReadLine());

            for (i = 0; i < 10; i++)
            {
                if (x == tab[i])
                {
                    Console.WriteLine("{0} se trouve à l'indice {1}", x, i);
                    res = true;
                }
            }
            if (!res)
            {
                Console.WriteLine("{0} n'est pas dans le tableau", x);
            }
            Console.ReadKey();
        }
    }
}
