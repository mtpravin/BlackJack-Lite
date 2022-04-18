using System;
using System.Threading;

namespace BlackJack
{
    public static class Dialog
    {
        public static void WelcomeDisplay()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------- ");
            Console.WriteLine("| ♠       ♥  |");
            Console.WriteLine("| BlackJack  |");
            Console.WriteLine("|            |");
            Console.WriteLine("|     A      |");
            Console.WriteLine("|            |");
            Console.WriteLine("| BlackJack  |");
            Console.WriteLine("| ♦       ♣  |");
            Console.WriteLine("-------------- ");
            Console.ResetColor();
            Console.WriteLine("Welcome to BlackJack ");
        }
        public static bool MenuDisplay()
        {
            while (true)
            {
                Console.WriteLine("1. New game");
                Console.WriteLine("2. Exit");

                var answerFromPlayer = Console.ReadLine();

                if (answerFromPlayer == "1")
                {
                    return true;
                }
                else if (answerFromPlayer == "2")
                {
                    Console.WriteLine("Exiting the game");
                    return false;
                }
                else
                {
                    Console.Clear();
                    WelcomeDisplay();
                    Console.WriteLine("Command does not exist");
                }
            }
        }

        public static bool ContinueDisplay()
        {
            while (true)
            {
                Console.WriteLine($"Would you like to draw one more card ?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                var answerFromPlayer = Console.ReadLine();

                if (answerFromPlayer == "1")
                {
                    return true;
                }
                else if (answerFromPlayer == "2")
                {
                    return false;
                }
                else
                {
                    //Console.Clear();
                    ContinueDisplay();
                    Console.WriteLine("Command does not exist");
                }
            }
        }

        public static void ShufflingDialog()
        {
            Console.WriteLine("\nShuffling the Cards");
            Thread.Sleep(1000);
            Console.WriteLine("Shuffling done");
        }
    }
}
