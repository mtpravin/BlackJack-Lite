using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Player
    {
        public string Name { get; set; }
        public List<int> Cards { get; set; }
        public int Score { get; set; }

        public int CardIndex = 0;

        public int CardsSize = 13;

        public string PlayingCard;

        public string[] DeckCards = new string[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        public int CardScore;

        public int TotalCardScore;

        public List<int> CardScores;

        public int[] TotalPoints = new int[4];

        public int Index = 0;

        public Player(string name)
        {
            Name = name;
            Cards = new List<int>();
        }

    }
}
