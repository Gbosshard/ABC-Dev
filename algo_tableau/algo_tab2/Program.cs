using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 0; ;
            string chaine;
            char c;
            Console.WriteLine("Ecrivez une chaine se terminant par un .");
            chaine = Console.ReadLine();
            Console.WriteLine("Quel carractère voulez vous trouvez");
            c = Char.Parse(Console.ReadLine());

            i = 0;
            while (chaine[i] != '.')
            {
                if (chaine[i] == c)
                {
                    n++;
                }
                i++;
            }
            if (i == 0)
            {
                Console.WriteLine("LA CHAINE EST VIDE");
            }
            else if (n == 0)
            {
                Console.WriteLine("la lettre n'est pas présente");
            }
            else
            {
                Console.WriteLine("la lettre est présente {0} fois", n);
            }

            Console.ReadKey();
        }
    }
}
