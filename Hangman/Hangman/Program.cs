using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1, please enter a secret word for player 2 to guess: ");
            string secretWord = Console.ReadLine();
            
            var letters = secretWord.ToCharArray();

            for (int ctr = 0; ctr < letters.Length; ctr++)
            {
                Console.Write(" _ ", ctr);
            }

            while (true)
            {
                Console.WriteLine("Type a letter to guess the word: ");
                string guessedLetter = Console.ReadLine();

                
            }
        }
    }
}
