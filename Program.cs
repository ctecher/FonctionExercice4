/**
 * Exercice 4 : ajout de la fonction saisie dans un programme
 * author : CT
 * date : 11/2021
 */
using System;

namespace FonctionExercice4
{
    class Program
    {
        /// <summary>
        /// Saisie de L ou E avec contrôle de saisie
        /// </summary>
        /// <returns>lettre statut</returns>
        static void Main(string[] args)
        {
            // Déclaration
            char statut;
            // Boucle sur la saisie correcte du statut
            do
            {
                Console.WriteLine();
                Console.Write("Etes-vous lycéen(ne) ou étudiant(e) ? (L/E) ");
                statut = Console.ReadKey().KeyChar;
            } while (statut != 'L' && statut != 'E');
            // Affichage du message personnalisé
            Console.WriteLine();
            if (statut == 'L')
            {
                Console.WriteLine("Bonjour lycée(ne).");
            }
            else
            {
                Console.WriteLine("Bonjour étudiant(e)");
            }
            Console.ReadLine();
        }
    }
}
