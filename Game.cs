using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BlackJack
{
    public class Game
    {
        public Player user;
        public Player pc;

        public Game()
        {
            Dialog.WelcomeDisplay();
            Console.WriteLine("Enter your Name:");
            user = new Player(Console.ReadLine());
            pc = new Player("Dealer");
        }

        public bool StartGame()
        {
            var GameStarts = Dialog.MenuDisplay();

            if (!GameStarts)
            {
                return false;
            }

            Dialog.ShufflingDialog();

            Draw2Cards(user);
            Console.WriteLine($"User Total Point is {user.Score}");          

            Draw2Cards(pc);

            for (int j = 0; j < 2; j++)
            { 
                var ContinueGame = Dialog.ContinueDisplay();

                if (!ContinueGame)
                {
                    return false;
                }

                DrawExtraCard(user);
                DrawExtraCard(pc);

                if (user.Score > 21)
                {
                    Console.WriteLine($"Burst - You Lost, your total Point is: {user.Score}");
                    return false;
                }
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"User Total Point is {user.Score}");
            
            CheckForWinner();
            return true;
        }

        private static void Draw2Cards(Player p1)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Cards for {p1.Name}");
            for (p1.Index=0 ; p1.Index < 2; p1.Index++)
            {
                DrawCard DCards = new DrawCard();
                p1.TotalPoints[p1.Index] = DCards.Draw(p1);
            }
            p1.Score = p1.TotalPoints.Sum();
        }

        private static void DrawExtraCard(Player p1)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Cards for {p1.Name}");
            DrawCard DCards = new DrawCard();
            p1.TotalPoints[p1.Index] = DCards.Draw(p1);
            p1.Score = p1.TotalPoints.Sum();
            p1.Index++;
        }

        private void CheckForWinner()
        {
            Console.WriteLine("Checking for the winner");
            Thread.Sleep(1000);

            if (user.Score > pc.Score)
            {
                Console.WriteLine($"The winner is {user.Name} ");
            }
            else { Console.WriteLine($"The winner is {pc.Name} "); }
        }


    }
}
