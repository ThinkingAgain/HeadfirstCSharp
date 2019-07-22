using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    enum Suits
    {
        Spades, Clubs, Diamonds, Hearts
    }
    enum Values
    {
        Ace = 1, Two = 2, Three = 3,
        Four =4, Five = 5, Six = 6,
        Seven = 7, Eight = 8, Nine = 9,
        Ten = 10, Jace = 11, Queen = 12,
        King =13
    }
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        //创建一副完整的52张牌的构造函数
        public Deck()
        {   
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        //另一个构造函数
        public Deck(IEnumerable<Card> inititalCards)
        {
            cards = new List<Card>(inititalCards);
        }

        //得牌
        public void Add(Card cardToAdd) { cards.Add(cardToAdd); }

        //出牌/发牌
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        
        //洗牌
        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                newCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = newCards;
        }



    }
}
