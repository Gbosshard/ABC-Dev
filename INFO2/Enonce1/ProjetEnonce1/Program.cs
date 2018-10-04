using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetEnonce1
{
    public class Program
    {

        public static void Main()
        {

            string sortie = null;
            
            Console.WriteLine("Lecture de l'énoncé");
            Console.WriteLine("Avez vous compris (o/n)");
            sortie = Console.ReadLine();
            if (sortie == "n")
            {
                Console.WriteLine("Relecture de l'énoncé");
                Console.WriteLine("Avez vous compris (o/n)");
                sortie = Console.ReadLine();
                if (sortie == "n")
                {
                    Console.WriteLine("Demander aux Formateur");
                }
                else
                {
                    Console.WriteLine("lecture de l'énoncé réussit");
                }
            }
            else
            {
                Console.WriteLine("lecture de l'énoncé réussit");
            }
            Console.WriteLine("Commencer le travail, écrire le pseudo-code");
            Console.WriteLine("le vérifier, ecrire le programme");
            Console.WriteLine("constituer le jeu d'essai et tester le programme");
            Console.ReadKey();
        }

    }

}
