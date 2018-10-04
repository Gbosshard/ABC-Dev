using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoPP97
{
    class Program
    {
        static void Main(string[] args)
        {
            string jma,sjour;
            int jour, mois, annee, resultat4, valeurMois, reste7;
            Console.WriteLine("taper une date entre 1900 et 2000 (jj/mm/aa)");
            jma = Console.ReadLine();

            jour = int.Parse(jma.Substring(0, 2));
            Console.WriteLine("jour = " + jour);
            mois = int.Parse(jma.Substring(3, 2));
            Console.WriteLine("mois = " + mois);
            annee = int.Parse(jma.Substring(6, 2));
            Console.WriteLine("année = 19{0:00}", annee);

            resultat4 = annee / 4;
            switch (mois)
            {
                case 1:
                    if ((annee % 4) != 0)
                    {
                        valeurMois = 1;
                    }
                    else
                    {
                        valeurMois = 0;
                    }
                    break;
                case 2:
                    if ((annee % 4) != 0)
                    {
                        valeurMois = 4;
                    }
                    else
                    {
                        valeurMois = 3;
                    }
                    break;
                case 3:
                    valeurMois = 4;
                    break;
                case 5:
                    valeurMois = 2;
                    break;
                case 6:
                    valeurMois = 5;
                    break;
                case 8:
                    valeurMois = 3;
                    break;
                case 9:
                    valeurMois = 6;
                    break;
                case 10:
                    valeurMois = 1;
                    break;
                case 11:
                    valeurMois = 4;
                    break;
                case 12:
                    valeurMois = 6;
                    break;
                default:
                    valeurMois = 0;
                    break;
            }

            reste7 = (annee + resultat4 + valeurMois + jour) % 7;
            switch (reste7)
            {
                case 1:
                    sjour = "Dimanche";
                    break;
                case 2:
                    sjour = "Lundi";
                    break;
                case 3:
                    sjour = "Mardi";
                    break;
                case 4:
                    sjour = "Mercredi";
                    break;
                case 5:
                    sjour = "Jeudi";
                    break;
                case 6:
                    sjour = "Vendredi";
                    break;
                default:
                    sjour = "Samedi";
                    break;

            }

            Console.WriteLine("ce jour était un "+ sjour);
            Console.ReadKey();
        }
    }
}
