using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    public enum Suits
    {
        Spades, Clubs, Diamonds, Hearts
    }
    public enum Values
    {
        Ace = 1, Two = 2, Three = 3,
        Four =4, Five = 5, Six = 6,
        Seven = 7, Eight = 8, Nine = 9,
        Ten = 10, Jace = 11, Queen = 12,
        King =13
    }
    partial class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
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

        //牌的数量
        public int Count { get { return cards.Count;  } }

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

        //

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }
        
            
        //public void Sort()

        //新增加的方法
        
        //查看给定序号的牌
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        //出最上面的第一张牌
        public Card Deal() { return Deal(0); }

        //public bool ContainsValue(Values value)
        
        //从一副牌中取出指定点数的牌并返回
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        //public bool HasBook(Values value)
        
        //按先点数后花色排序
        public void SortByValue() { cards.Sort(new CardComparer_byValue()); }

    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value < y.Value) return -1;
            if (x.Value > y.Value) return 1;
            if (x.Suit < y.Suit) return -1;
            if (x.Suit > y.Suit) return 1;
            return 0;
        }
    }
}
