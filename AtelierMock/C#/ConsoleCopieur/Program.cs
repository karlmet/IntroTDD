using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaractereCopieur;

namespace ConsoleCopieur
{
    internal static class Program
    {
        private class SourceConsole : Interfaces.ISource
        {
            public char ObtenirChar()
            {
                int x = Console.Read();
                return Convert.ToChar(x);
            }
        }

        private class DestinationConsole : Interfaces.IDestination
        {
            public void FixerChar(char nouveau)
            {
                Console.WriteLine(nouveau);
            }
        }

        private static void Main(string[] args)
        {
            Copieur copieur = new Copieur(new SourceConsole(), new DestinationConsole());
            copieur.Copier();

            Console.Read();
        }
    }
}