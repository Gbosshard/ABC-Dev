/*
 * Q1
 * Déclaration
 * 
 * Entier nb_prepatateur
 * Entier nb_entrepot
 * Tableau entier[nb_prepatateur,2] tabProductivite
 * Tableau chaine[nb_entrepot] tabCodeEntrepot
 * Tableau entier[nb_entrepot] tabPrepaParEnt
 * Tableau float[nb_entrepot] tabMoyenne
 * Entier nb, prepaParEnt
 * 
 * Définition
 * 
 * tabProductivite[0,0] <-- 2   // épicerie
 * tabProductivite[0,1] <-- 85  // colis/heure
 * ...
 * tabCodeEntrepot[2]   <-- "épicerie"
 * ...
 * tabPrepaParEnt <-- tout à 0
 * tabMoyenne <-- tout à 0
 * 
 * Code
 * 
 * pour nb de 0 à nb_preparateur par 1
 * faire
 * prepaParEnt    <-- tabPrepaParEnt[tabProductivite[nb,0]]
 * tabMoyenne[tabProductivite[nb,0]]    <-- (tabMoyenne[tabProductivite[nb,0]]*prepaParEnt + tabProductivite[nb])/(prepaParEnt+1)
 * tabPrepaParEnt[tabProductivite[nb,0]]    <-- prepaParEnt + 1
 * finpour
 * afficher "entrepot || moyenne de productivité"
 * pour nb de 0 à nb_entrepot par 1
 * faire
 * afficher tabCodeEntrepot[nb]+" || "+tabMoyenne[nb]
 * finpour
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb_preparateur = 2;
            int nb_entrepot = 4;
            int[,] tabProductivite = new int[nb_preparateur, 2];
            string[]  tabCodeEntrepot = new string[nb_entrepot];
            int[] tabPrepaParEnt = new int[nb_entrepot];
            float[] tabMoyenne = new float[nb_entrepot];
            int nb, compte;
            
            tabProductivite[0,0] = 1;   // épicerie
            tabProductivite[0,1] = 85;  // colis/heure
            tabProductivite[1,0] = 0;
            tabProductivite[1,1] = 100;

            tabCodeEntrepot[0] = "GD magasins";
            tabCodeEntrepot[1] = "frais";
            tabCodeEntrepot[2] = "épicerie";
            tabCodeEntrepot[3] = "pondereux";
        }
    }
}
