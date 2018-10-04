using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_tab6
{
    class Program
    {
        static void AfficherPendu(ref char[,] pendu, string _mot, int _essai)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            Console.Clear();
            
            switch (_essai)
            {
                case 6: // jambe droite
                    pendu[8, 5] = (char)177;
                    pendu[9, 5] = (char)177;
                    pendu[10, 5] = (char)219;
                    pendu[10, 4] = (char)219;
                    break;
                case 5: // jambe gauche
                    pendu[8, 7] = (char)177;
                    pendu[9, 7] = (char)177;
                    pendu[10, 7] = (char)219;
                    pendu[10, 8] = (char)219;
                    break;
                case 4: // bras gauche
                    pendu[5, 8] = (char)178;
                    pendu[5, 9] = (char)178;
                    pendu[6, 9] = (char)219;
                    break;
                case 3: // bras droit
                    pendu[5, 4] = (char)178;
                    pendu[5, 3] = (char)178;
                    pendu[6, 3] = (char)219;
                    break;
                case 2: // corps
                    pendu[4, 6] = (char)219;
                    pendu[5, 5] = (char)178;
                    pendu[5, 6] = (char)178;
                    pendu[5, 7] = (char)178;
                    pendu[6, 5] = (char)178;
                    pendu[6, 6] = (char)178;
                    pendu[6, 7] = (char)178;
                    pendu[7, 5] = (char)178;
                    pendu[7, 6] = (char)178;
                    pendu[7, 7] = (char)178;
                    break;
                case 1: // tete
                    pendu[1, 6] = (char)178;
                    pendu[2, 5] = (char)219;
                    pendu[2, 6] = (char)219;
                    pendu[2, 7] = (char)219;
                    pendu[3, 5] = (char)219;
                    pendu[3, 6] = (char)219;
                    pendu[3, 7] = (char)219;
                    break;
                default: // init et potence
                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            pendu[i, j] = (char)0;
                        }
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        pendu[i, 0] = (char)219;
                        pendu[0, i] = (char)219;
                    }
                    break;
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\n ");
                for (int j = 0; j < 12; j++)
                {
                     Console.Write(pendu[i,j]);
                }
            }
            Console.WriteLine(_mot);
            if (_essai != 0)
            {
                Console.WriteLine("{0} essais infructueux", _essai);
            }
        }

        static void Main(string[] args)
        {
            char[,] pendu = new char[12, 12];
            string mot, mot_a_trou;
            char c;
            int i, essai = 0;
            bool test;

            do
            {
                Console.WriteLine("entrez un mot");
                mot = Console.ReadLine();
            } while (mot.Length < 5);

            for (i = 0; i < 30; i++)
			{
                Console.WriteLine();
			}

            mot_a_trou = mot.Substring(0,1);
            i = 0;
            do
            {
                mot_a_trou += "-";
                i++;
            } while (i < mot.Length-2);
            mot_a_trou += mot.Substring(mot.Length-1,1);

            do
            {
                AfficherPendu(ref pendu, mot_a_trou, essai);
                do
	            {
                    Console.WriteLine("entrez une lettre :");
                    test = char.TryParse(Console.ReadLine(), out c);
	            } while (!test);
                
                for (i = 0; i < mot.Length; i++)
                {
                    if (mot[i] == c)
                    {
                        mot_a_trou = mot_a_trou.Substring(0,i) + c + mot_a_trou.Substring(i+1,mot.Length-i-1);
                        test = false;
                    }
                }
                if (test)
                {
                    essai++;
                }
            } while ((mot != mot_a_trou) && (essai < 6));

            if (mot == mot_a_trou)
            {
                AfficherPendu(ref pendu, mot_a_trou, essai);
                Console.WriteLine("bravo !!!");
            }
            else
            {
                AfficherPendu(ref pendu, mot_a_trou, essai);
                Console.WriteLine("pendu !!!");
                Console.WriteLine("le mot etait : "+ mot);
            }
            Console.ReadKey();
        }
    }
}
