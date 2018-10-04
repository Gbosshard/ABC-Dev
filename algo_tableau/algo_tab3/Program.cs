using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string chaine;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char c;
            int[] occur = new int[26];

            for(i=0; i<26; i++)
            {
                occur[i] = 0;
            }
            Console.WriteLine("Ecrivez une chaine se terminant par un .");
            chaine = Console.ReadLine();
            while (chaine.Length < 120)
            {
                Console.WriteLine("Lazy chaine est trop courte ajouter des mots");
                chaine += Console.ReadLine();
            }
            chaine = chaine.ToLower();
            for (i=0; i<chaine.Length; i++)
            {
                c = chaine[i];
                for(j = 0; j<26; j++) {
                    if (c == alphabet[j])
                    {
                        occur[j]++;
                    }
                }
            }
            for (i = 0; i < 26; i++)
            {
                Console.WriteLine("{0} : {1}", alphabet[i], occur[i]);
            }
            Console.ReadKey();
        }
    }
}
