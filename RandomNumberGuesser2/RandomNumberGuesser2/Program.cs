using RandomNumberGuesser2;
using System;

namespace RanddomNumberGuesser_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool background = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("____ _   _           _                 _   _ _   _           _                ____                               \r\n |  _ (_)_(_)_ __   __| | ___  _ __ ___ | \\ | (_)_(_)_ __ ___ | |__   ___ _ __ / ___|_   _  ___  ___ ___  ___ _ __ \r\n | |_) / _` | '_ \\ / _` |/ _ \\| '_ ` _ \\|  \\| |/ _ \\| '_ ` _ \\| '_ \\ / _ \\ '__| |  _| | | |/ _ \\/ __/ __|/ _ \\ '__|\r\n |  _ < (_| | | | | (_| | (_) | | | | | | |\\  | (_) | | | | | | |_) |  __/ |  | |_| | |_| |  __/\\__ \\__ \\  __/ |   \r\n |_| \\_\\__,_|_| |_|\\__,_|\\___/|_| |_| |_|_| \\_|\\___/|_| |_| |_|_.__/ \\___|_|   \\____|\\__,_|\\___||___/___/\\___|_|   \r\n ");
            Console.ForegroundColor = ConsoleColor.White;           
            Console.WriteLine("Möchtest du die Hintergrundfarbe der Konsole ändern? (black/white)");
            string hintergrundFarbe = Console.ReadLine();

            if (hintergrundFarbe.ToLower() == "black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White; // Schwarzer Hintergrund, weißer Text
                Console.Clear();
                background = false;

            }
            else if (hintergrundFarbe.ToLower() == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black; // Weißer Hintergrund, schwarzer Text
                Console.Clear();
            }
            else 
            {
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Antworte mit black oder white!");
                Environment.Exit(0);
            }
            string antwort;
            
            if (background == false)
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

                NumberGame game = new NumberGame();

                do
                {
                    string eingabe = Console.ReadLine();

                    if (int.TryParse(eingabe, out int zahl))
                    {
                        if (game.Guess(zahl))
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl zwischen 1 und 100 eingeben.");
                    }
                } while (true);

                Console.WriteLine("Möchtest du nochmal spielen? (ja/nein): ");
                antwort = Console.ReadLine();
            }

            Console.WriteLine("Schade Marmelade, dann halt nicht");
            Environment.Exit(0);
        }
    }
}
