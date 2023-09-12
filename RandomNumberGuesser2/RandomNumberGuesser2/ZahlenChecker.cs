using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGuesser2 {
    public class NumberGame
    {
        private int _ratezahl;
        private int _versuche;

        public int Versuche => _versuche;

        public NumberGame()
        {
            _versuche = 0;
            StartGame();
        }

        public void StartGame()
        {
            Random random = new Random();
            _ratezahl = random.Next(1, 100);
        }

        public bool Guess(int number)
        {
            _versuche++;

            if (number > _ratezahl)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SchadeMarmelade, meine Zahl ist tiefer");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            else if (number < _ratezahl)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("EvilKnivel, meine Zahl ist höher");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du Sigma, das war meine Zahl");
                Console.WriteLine($"Du hast nur {_versuche} Versuche gebraucht.");
                Console.ForegroundColor = ConsoleColor.White;
                _versuche = 0;
                return true;
            }
        }
    }
}