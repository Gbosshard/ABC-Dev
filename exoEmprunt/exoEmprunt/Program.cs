using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoEmprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool saisie;
            double tauxAnnuel;      // tauxAnnuel    ->  taux de l'interet annuel
            double tauxMensuel;
            int nbrAnneeRbmt;       // nbrAnneeRbmt         ->  le nombre d'annee de remboursement
            double capitalEmprunte; // capitalEmprunte      ->  le capital emprunte
            double capitalRestant;
            double annuite;         // annuite              ->  le montant de l'annuite a rembourser
            double mensualite;      // mensualite           ->  la mensualite equivalente a rembourser
            int mois;               // mois                 ->  le nombre de mois de la période
            double interetMois;     // interetMois          ->  les intérets du mois courant
            double amortissementMois;// amortissementMois    ->  le montant de l'ammortissement pour le mois courant

            do
            {
                Console.WriteLine("Quel est taux de l'interet annuel de l'emprunt?");
                saisie = double.TryParse(Console.ReadLine(), out tauxAnnuel);
            } while (!saisie);
            tauxAnnuel = tauxAnnuel / 100;
            do
            {
                Console.WriteLine("Quel est le capital emprunté?");
                saisie = double.TryParse(Console.ReadLine(), out capitalEmprunte);
            } while (!saisie);
            do
            {
                Console.WriteLine("Quel est le nombre d'annee de remboursement?");
                saisie = int.TryParse(Console.ReadLine(), out nbrAnneeRbmt);
            } while (!saisie);
            mois = nbrAnneeRbmt * 12;

            tauxMensuel = tauxAnnuel/12;
            mensualite = capitalEmprunte * tauxMensuel / (1 - Math.Pow((1 + tauxMensuel), -mois));
            annuite = capitalEmprunte * tauxAnnuel / (1 - Math.Pow((1 + tauxAnnuel), -nbrAnneeRbmt));
            Console.WriteLine("mensualité constante : {0:#,###.00}, annuité constante : {1:#,###.00}", mensualite, annuite);
            Console.ReadKey();

            capitalRestant = capitalEmprunte;
            Console.WriteLine("num mois // part interet // part capital // capital restant // mensualité");
            for (int n = 0; n < mois; n++)
            {
                interetMois = capitalRestant * tauxMensuel;
                amortissementMois = mensualite - interetMois;
                capitalRestant -= amortissementMois;
                Console.WriteLine("{0: 000}\t  ||\t{1: 0.0}\t ||\t{2: 0.0}\t ||\t{3: #,##0}\t||\t{4: #}", n + 1, interetMois, amortissementMois, capitalRestant, mensualite);
            }
            Console.ReadKey();
        }
    }
}
