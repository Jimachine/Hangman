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
            // Enter a word to be guessed, change this to take a random word from a file containing a list of words 
            Console.WriteLine("Player 1, please enter a secret word for player 2 to guess: ");
            string secretWord = Console.ReadLine();
            
            // Convert the entered word to an array of characters
            var letters = secretWord.ToCharArray();

            // Count how many letters are in the word and then display that many underscores
            for (int ctr = 0; ctr < letters.Length; ctr++)
            {
                Console.Write(" _ ", ctr);
            }

            // Guess a letter and check the array for a match
            while (true)
            {
                Console.WriteLine("Type a letter to guess the word: ");
                string guessedLetter = Console.ReadLine();
                char charGuess = Convert.ToChar(guessedLetter);

                // Create a char variable and give it the value of "letters"
                char[] chars = new char[letters.Length];
                chars = letters;

                // Loop through every character in "chars" and check to see if any characters match those entered
                foreach (char c in chars)
                {
                    if (c == charGuess)
                    {
                        Console.Write(charGuess);
                    }

                    else
                    {
                        Console.Write("*");
                    }
                }

            }
        }
    }
}
