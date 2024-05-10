using System.Collections.Immutable;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Topic_8._5___Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "CALCULUS";
            string yesOrNo, guessletter, wrongLetter;
            bool stopPlaying = false;
            int guesses = 0;
            List<string> wordDisplay = new List<string>();
            wordDisplay.Add("_ ");
            wordDisplay.Add("_ ");
            wordDisplay.Add("_ ");
            wordDisplay.Add("_ ");
            wordDisplay.Add("_ ");
            wordDisplay.Add("_ ");
            wordDisplay.Add("_ ");
            wordDisplay.Add("_");
            Console.WriteLine("Welcome to Hangman!!");
            Console.WriteLine("Would you like to continue? (Y or N)");
            yesOrNo = Console.ReadLine().ToUpper();

            if (yesOrNo == "Y")
            {
                while (!stopPlaying && guesses != 7)
                {
                    Console.Clear();
                    Console.WriteLine("Guess the secert word, letter by letter:");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine();
                    for (int i = 0; i < wordDisplay.Count; i++)
                        Console.Write(wordDisplay[i]);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Guess here: ");
                    guessletter = Console.ReadLine().ToUpper().Trim();


                    }

                    else if (guessletter.ToUpper() == "A")
                    {

                    }

                    else if (guessletter.ToUpper() == "L")
                    {

                    }

                    else if (guessletter.ToUpper() == "U")
                    {

                    }

                    else if (guessletter.ToUpper() == "S")
                    {

                    }

                    else if (guessletter.Length > 1 || !Regex.IsMatch(guessletter, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Invalid character, please guess again.");
                    }
                    else
                    {
                        guesses++;
                    }
                }
            }

            else
            {
                Console.WriteLine("uh, bye then *waves*");
                Thread.Sleep(500);
            }
        }


        public static void HangmanGuesses(int guesses)
        {
            switch (guesses)
            {
                    case 0: 
                    Console.WriteLine("");
                    break;

                    case 1: 
                    Console.WriteLine("");
                    break;

                    case 2: 
                    Console.WriteLine("");
                    break;

                    case 3: 
                    Console.WriteLine("");
                    break;

                    case 4: 
                    Console.WriteLine("");
                    break;

                    case 5:
                    Console.WriteLine("");
                    break;

                    case 6:
                    Console.WriteLine("");
                    break;

                    case 7:
                    Console.WriteLine("");
                    break;

                    case 8:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
