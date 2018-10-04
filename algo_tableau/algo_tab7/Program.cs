using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prenoms = new string[7] {"agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie"};
            string prenom;
            int min = 0, max = prenoms.Length - 1, median, i;

            Console.WriteLine("entrez un prenom :");
            prenom = Console.ReadLine();

            do
            {
                median = min + (max - min) / 2;
                Console.WriteLine("min : {0}, max : {1}, median {2}", min, max, prenoms[median]);

                i = 0;
                while (i < prenom.Length - 1 && i < prenoms[median].Length - 1 && prenom[i] == prenoms[median][i])
                {
                    i++;
                }
                if (prenom[i] <= prenoms[median][i])
                {
                    max = median - 1;
                }
                else
                {
                    min = median + 1;
                }
            } while ((prenom != prenoms[median]) && (min <= max));

            if (prenom == prenoms[median])
            {
                Console.WriteLine("{0} {1}", median+1, prenoms[median]);
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}
