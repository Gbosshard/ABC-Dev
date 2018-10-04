using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_tab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string chaine;
            string[] ch2;
            bool palindrome = true;
            Console.WriteLine("entrez une chaine terminer par un point");
            chaine = Console.ReadLine();
            chaine = chaine.ToUpper();
            chaine = chaine.Substring(0, chaine.IndexOf('.'));
            ch2 = chaine.Split(' ');
            chaine = "";
            for (i = 0; i < ch2.Length; i++)
            {
                chaine += ch2[i];
            }
            //Console.WriteLine(chaine);
            if (chaine.Length == 0)
            {
                Console.WriteLine("la chaine est vide");
            }
            else
            {
                for (i = 0; i <= (chaine.Length / 2); i++)
                {
                    if (chaine[i] != chaine[chaine.Length - i - 1])
                    {
                        palindrome = false;
                        break;
                    }
                }
                if (palindrome)
                {
                    Console.WriteLine("c'est un palindrome");
                }
                else
                {
                    Console.WriteLine("ce n'est pas un palindrome");
                }
            }
            Console.ReadKey();
        }
    }
}
