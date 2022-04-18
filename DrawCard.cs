using System;
using System.Linq;

namespace BlackJack
{
    public class DrawCard
    {
        //public Player p1;

        public int Draw(Player p1)
        {

            var randomcard = new Random();

            p1.CardIndex = randomcard.Next(p1.CardsSize);

            p1.PlayingCard = p1.DeckCards[p1.CardIndex];
         
            if (p1.CardIndex == 0)
            {
                p1.CardScore = 11;
            }
            else if (p1.CardIndex < 9)
            {
                p1.CardScore = p1.CardIndex + 1;
            }
            else
            {
                p1.CardScore = 10;
            }

            if (p1.Name == "Dealer" && p1.Index == 1)  
            {
                Console.WriteLine("Dealer second card  is Face down");
            }
            else
            {
                Console.WriteLine($"Card Drawn is :{p1.PlayingCard}");
                Console.WriteLine($"Card Point is :{p1.CardScore}");
            }
           
            return p1.CardScore;
        }
    }
}
