using RandomNumberGuesser2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

namespace RandomNumberGuesser2
{
    public class Background
    {
        public void Run()
        {
            bool background = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your ASCII Art Here");
            Console.ResetColor(); // Reset color to default

            Console.WriteLine("Möchtest du die Hintergrundfarbe der Konsole ändern? (black/white)");
            string hintergrundFarbe = Console.ReadLine();

            if (hintergrundFarbe.ToLower() == "black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                background = false;
            }
            else if (hintergrundFarbe.ToLower() == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Antworte mit black oder white!");
                Environment.Exit(0);
            }

            string antwort = "";

            if (!background)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Perfekt, nun können wir anfangen:");
                Console.WriteLine("Merhaba Kamerad, kleines Spiel gefällig?");
                antwort = Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Perfekt, nun können wir anfangen:");
                Console.WriteLine("Merhaba Kamerad, kleines Spiel gefällig?");
                antwort = Console.ReadLine();
            }

            while (antwort.ToLower() == "ja" || antwort.ToLower() == "yes" || antwort.ToLower() == "positiv" || antwort.ToLower() == "oui" || antwort.ToLower() == "si")
            {
                Console.WriteLine("Papatastisch, dann lass uns beginnen.");
                Console.WriteLine("Das Spiel ist SimpleDimple, du musst eine von mir gesetzte Zahl zwischen 1-100 erraten, lesgo:");

                // You should update antwort here to break out of the loop when the user gives a different response.
                antwort = Console.ReadLine();
            }
        }
    }
}
