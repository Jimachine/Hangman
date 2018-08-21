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


            Random rnd = new Random();
            string[] listOfWords = System.IO.File.ReadAllLines(@"C:\Users\jimmy\Documents\Coding\Hangman\Hangman\Hangman\WordList.txt");
            int wordIndex = rnd.Next(listOfWords.Length);
            string secretWord = listOfWords[wordIndex];
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
                    
                    
                    if (playerGuess == secretChar[c])
                    {
                        guess[c] = playerGuess;
                        string a = new string(guess);
                        int d = string.Compare(a, secretWord);

                        if (d == 0)
                        {
                            Console.WriteLine("Well done! The secret word was: " + secretWord);
                            return;
                        }
                    }
                }
                

            }
        }
    }
}