using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, k, temp;
            Random rand = new Random();
            Console.WriteLine("Quelle est la taille du tableau?");
            n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];
            for (i = 0; i < n; i++)
            {
                tab[i] = rand.Next(n * 2);
                Console.Write("{0} ", tab[i]);
            }
            Console.WriteLine("\ntableau rangé :");
            for (i = 0; i < n; i++)
            {
                k = i;
                for (j = i; j < n; j++)
                {
                    if (tab[k] > tab[j])
                    {
                        k = j;
                    }
                }
                temp = tab[i];
                tab[i] = tab[k];
                tab[k] = temp;
                Console.Write("{0} ", tab[i]);
            }
            Console.ReadKey();
        }
    }
}
