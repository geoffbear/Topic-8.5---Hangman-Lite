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
            List<string> lettersGuessed = new List<string>();
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
                    HangmanGuesses(guesses);
                    Console.WriteLine();
                    for (int i = 0; i < wordDisplay.Count; i++)
                        Console.Write(wordDisplay[i]);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Letters guessed: ");
                    for (int i = 0; i < lettersGuessed.Count; i++)
                        Console.Write(lettersGuessed[i] + ", ");

                    Console.WriteLine();
                    Console.WriteLine("Guesses used: " + guesses + "/7");
                    Console.Write("Guess here: ");
                    guessletter = Console.ReadLine().ToUpper().Trim();
                    Console.WriteLine();


                    if (guessletter.ToUpper() == "C" )
                    {
                        wordDisplay[0] = "C ";
                        wordDisplay[3] = "C ";
                    }

                    else if (guessletter.ToUpper() == "A")
                    {
                        wordDisplay[1] = "A ";
                    }

                    else if (guessletter.ToUpper() == "L")
                    {
                        wordDisplay[2] = "L ";
                        wordDisplay[5] = "L ";
                    }

                    else if (guessletter.ToUpper() == "U")
                    {
                        wordDisplay[4] = "U ";
                        wordDisplay[6] = "U ";
                    }

                    else if (guessletter.ToUpper() == "S")
                    {
                        wordDisplay[7] = "S";
                    }

                    else if (guessletter.Length > 1 || !Regex.IsMatch(guessletter, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Invalid character, please guess again.");
                    }

                    else
                    {
                        guesses++;
                        lettersGuessed.Add(guessletter);
                    }

                    if (wordDisplay[0].Contains("C") && wordDisplay[1].Contains("A") && wordDisplay[2].Contains("L") && wordDisplay[4].Contains("U") && wordDisplay[7].Contains("S"))
                    {   
                        wordDisplay[0] = "C ";
                        wordDisplay[1] = "A ";
                        wordDisplay[2] = "L ";
                        wordDisplay[3] = "C ";
                        wordDisplay[4] = "U ";
                        wordDisplay[5] = "L ";
                        wordDisplay[6] = "U ";
                        wordDisplay[7] = "S";
                        Console.WriteLine("You have won!!! Congrats!!! (Press Enter to continue)");
                        Console.ReadLine();

                        stopPlaying = true;
                    }

                }
                Console.WriteLine("The word was " + word + ". Thanks for playing.");
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
                    Console.WriteLine("  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========\r\n");
                    break;

                    case 1: 
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========\r\n");
                    break;

                    case 2: 
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========\r\n");
                    break;

                    case 3: 
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========\r\n");
                    break;

                    case 4: 
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========\r\n");
                    break;

                    case 5:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========\r\n");
                    break;

                    case 6:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========\r\n");
                    break;

                    case 7:
                    Console.WriteLine("  +---+\r\n      |\r\n      | \r\n \\O/  |\r\n  |   |\r\n / \\  |\r\n=========");
                    break;
            }
        }
    }
}
