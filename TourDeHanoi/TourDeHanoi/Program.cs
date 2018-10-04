using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDeHanoi
{
    class Program
    {
        static int Compte;

        static int[,] InitHanoi()
        {
            Compte = 0;
            int[,] tour = new int[3,5] { { 1, 2, 3, 4, 5 },
                                          { 0, 0, 0, 0, 0},
                                          { 0, 0, 0, 0, 0 } };
            return tour;
        }
        static void AfficherTour(ref int[,] tour)
        {
            for (int x = 0; x < 5; x++)
            {
                Console.Write("\n");
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("\t" + tour[y, x]);
                }
            }
            Console.ReadKey();
        }

        static void Move(ref int[,] tour, int dep, int dest)
        {
            Console.WriteLine();
            int depi = 0, desti = 0, pion = 0;
            if ((dep != dest) && (dep%3 == dep) && (dest%3 == dest))
            {
                // check pile de départ
                while ((depi < 5) && (tour[dep, depi] == 0))
                {
                    depi++;
                }
                if (depi == 5)
                {
                    Console.WriteLine("error tour[dep] vide");
                    return;
                }
                else
                {
                    pion = tour[dep, depi];
                    // check pile d'arrivée
                    while ((desti < 5) && (tour[dest, desti] == 0))
                    {
                        desti++;
                    }
                    if ((desti == 5) || (tour[dest, desti] > pion))
                    {
                        tour[dep, depi] = 0;
                        tour[dest, desti - 1] = pion;
                        Compte++;
                        Console.WriteLine("mouvement n°{0}", Compte);
                        AfficherTour(ref tour);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("error tour[dest] > pion");
                        return;
                    }
                }

            }
            else
            {
                Console.WriteLine("error dep dest");
                return;
            }
        }

        static void DeplaceTour(ref int[,] tour, int dep, int dest, int prof)
        {
            int dest2;
            if ((dep != dest) && (prof > 0) && (dep % 3 == dep) && (dest % 3 == dest))
            {
                dest2 = 3 - dep - dest;
                DeplaceTour(ref tour, dep, dest2, prof-1);
                Move(ref tour, dep, dest);
                DeplaceTour(ref tour, dest2, dest, prof - 1);
            }
        }

       static void RangeTour(ref int[,] tour)
        {
           Random rnd = new Random();
           int i, pres = 0, las;
           for (i = 5; i > 0; i--)
           {
               las = pres;
               pres = rnd.Next(3);
               DeplaceTour(ref tour, las, pres, i);
           }
        }

        static void Main(string[] args)
        {
            int[,] tour = InitHanoi();
            AfficherTour(ref tour);
            //DeplaceTour(ref tour, 0, 2, 5);
            //DeplaceTour(ref tour, 2, 0, 5);
            RangeTour(ref tour);

            Console.ReadKey();
        }
    }
}
