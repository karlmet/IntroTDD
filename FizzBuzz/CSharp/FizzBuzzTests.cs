using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        // Rappel TDD: 
        //   1. Rouge: Écrire un test 
        //   2. Rouge: Vérifier que le test échoue. Le code qu’il teste n’existe pas donc le test est invalide
        //   3. Vert: Écrire juste le code suffisant pour  passer le test
        //   4. Vert: S’assurer que le test passe
        //   5. Perfectionner: Améliorer le code tout en gardant les même fonctionnalités

        // Règles de l'oncle Bob
        //   Vous ne pouvez écrire aucune ligne de code de production excepté pour faire passer un test unitaire en erreur.
        //   Vous devez arrêter d’écrire des lignes de code d’un test quand il se met à échouer.
        //   Vous ne pouvez écrire plus de lignes de code de production qu’il est nécessaire pour faire passer ce nouveau test en erreur.

        // Patron AAA:
        //   Arranger (Arrange) : préparer le contexte nécessaire pour exécuter le agir
        //   Agir (Act) : appeler le bout de code que l’on veut tester
        //   Assertions (Assert) : vérifier que le bout de code a fonctionné correctement


        // Description du Kata
        // ========================================================================================
        // Écrire un programme qui affiche les numéros de 1 à 100.
        // Par contre, pour les multiples de 3 on écrit « Fizz » à la place. 
        // Pour les multiples de 5, c’est « Buzz ».
        // Pour les nombres qui sont à la fois des multiples de 3 et de 5, on écrit « FizzBuzz ». 
        // ========================================================================================

        [TestMethod]
        public void Test()
        {

        }
    }
}
