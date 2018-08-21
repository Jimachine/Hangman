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


            // Enter a word to be guessed
            Console.WriteLine("Player 1, please enter a secret word for player 2 to guess: ");
            string secretWord = Console.ReadLine();
            char[] guess = new char[secretWord.Length];
            char[] secretChar = secretWord.ToCharArray();
            


            // Count how many letters are in the word and then store that many underscores in the 'guess' variable
            for (int ctr = 0; ctr < secretWord.Length; ctr++)
            {
                guess[ctr] = '_';
            }

            //Guess a letter and check the secret word for a match
            while (true)
            {
                
                Console.WriteLine(guess);
                Console.WriteLine("Type a letter to guess: ");
                char playerGuess = char.Parse(Console.ReadLine());

                // If playerGuess matches a letter in 'secretWord' store it in 'guess'
                for (int c = 0; c < secretWord.Length; c++)
                {
                    string a = new string(guess);
                    int d = string.Compare(a, secretWord);

                    if (d == 0)
                    {
                        Console.WriteLine("Well done! The secret word was: " + secretWord);
                        return;
                    }
                    
                    else if (playerGuess == secretChar[c])
                    {
                        guess[c] = playerGuess;
                    }
                }
                

            }
        }
    }
}