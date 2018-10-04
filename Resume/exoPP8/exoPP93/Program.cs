using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP93
{
    class Program
    {
        static void Main(string[] args)
        {
            int Annee;
            string biss;
            Console.WriteLine("indiquez une année :");
            Annee = int.Parse(Console.ReadLine());
            if ((Annee % 4) != 0)
            {
                biss = "Non bissextile suivant le cas : non divisible par 4";
            }
            else if (((Annee % 100) != 0) || ((Annee % 400) == 0))
            {
                biss = "Bissextile";
            }
            else
            {
                biss = "Non bissextile suivant le cas : divisible par 100 mais pas par 400";
            }
            Console.WriteLine(biss);
            Console.ReadKey();
        }
    }
}
