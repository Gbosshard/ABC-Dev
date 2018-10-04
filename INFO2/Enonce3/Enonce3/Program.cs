using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enonce3
{
    class Program
    {
        static void Main(string[] args)
        {

            string question = null;
            bool range = false;
            int anneeEdition = 0;

            int numlivre = 0;
            int nblivre = 0;

            int rayonScol = 0;
            int rayonAutre = 0;

            int BOITESCOL = 0;
            int BOITEROM = 0;
            int BOITEDIV = 0;

            Console.WriteLine("combien y a t'il de livre dans la bibliotèque?");
            nblivre = int.Parse( Console.ReadLine() );


            do
            {
                numlivre++;
                Console.WriteLine("classement du livre numero " + numlivre + " :");
                // classement
                Console.WriteLine("est-ce un ouvrage scolaire? (o/n)");
                question = Console.ReadLine();
                if (question == "o") // livre scolaire
                {
                    Console.WriteLine("est-ce qu'il traite de littérature, de philosaphie ou de langues étrangères? (o/n)");
                    question = Console.ReadLine();
                    if (question == "o")
                    {
                        Console.WriteLine("quelle est l'année d'edition?");
                        anneeEdition = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        anneeEdition = 0;
                    }
                    if (anneeEdition >= 1995)
                    {
                        Console.WriteLine("ajouté au rayon ouvrages scolaires");
                        rayonScol++;
                    }
                    else
                    {
                        Console.WriteLine("ajouté à la boite BOITESCOL");
                        BOITESCOL++;
                    }
                }
                else // pas livre scolaire
                {
                    range = false;
                    Console.WriteLine("Est-ce un livre de poche?(o/n)");
                    question = Console.ReadLine();
                    if (question == "o")
                    {
                        Console.WriteLine("Avez vous déjà lu le livre?(o/n)");
                        question = Console.ReadLine();
                        if (question == "n")
                        {
                            Console.WriteLine("ajouté au rayon autres ouvrages");
                            rayonAutre++;
                            range = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("le livre est il détérioré?(o/n)");
                        question = Console.ReadLine();
                        if (question == "n")
                        {
                            Console.WriteLine("ajouté au rayon autres ouvrages");
                            rayonAutre++;
                            range = true;
                        }
                    }
                    if (!range)
                    {
                        Console.WriteLine("est ce un roman?(o/n)");
                        question = Console.ReadLine();
                        if (question == "o")
                        {
                            Console.WriteLine("ajouté à la boite BOITEROM");
                            BOITEROM++;
                        }
                        else
                        {
                            Console.WriteLine("ajouté à la boite BOITEDIV");
                            BOITEDIV++;
                        }
                    }
                }
            } while (nblivre > numlivre);

            Console.WriteLine("BILAN DES " + nblivre + " LIVRES RANGÉS :");
            Console.WriteLine(rayonScol + " ouvrage scolaire dans l'étagère");
            Console.WriteLine(rayonAutre + " autre ouvrage dans l'étagère");
            Console.WriteLine(BOITESCOL + " dans la boite étiquetée BOITESCOL");
            Console.WriteLine(BOITEROM + " dans la boite étiquetée BOITEROM");
            Console.WriteLine(BOITEDIV + " dans la boite étiquetée BOITEDIV");
            Console.ReadKey();
        }
    }
}
