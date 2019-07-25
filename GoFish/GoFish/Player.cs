using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            //此构造器初始化4个私有字段，
            //然后在窗体的TextBox控件增加一行文本“乔伊刚刚加入游戏”-但要使用私有字段的名字。
            //别忘记每行后面加换行
            this.name = name;
            this.random = random;
            this.cards = new Deck(new List<Card>());
            this.textBoxOnForm = textBoxOnForm;

            textBoxOnForm.AppendText(name + "刚刚加入游戏\r\n");

        }

        //查找玩家手中的完整套牌(book)，将其增加至要返回的books变量（可迭代的Values集合）中
        //并从玩家的牌中删除这一套牌
        public IEnumerable<Values> PullOutBooks() {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Values value)
        {
            //对手向你叫某个点数的牌
            //使用Deck.PullOutValues()取出该点数的牌。
            //在TextBox中增加一行“乔伊有3张6”-使用Card.Plural()静态方法-中文不用，嘻嘻 没复数
            Deck askFor = cards.PullOutValues(value);
            if (askFor.Count > 0)
            {
                textBoxOnForm.Text += name + "有" + askFor.Count + "张" + Card.returnPoints(value)
                    + Environment.NewLine;
            }
            return askFor;

        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            //AskForACard的重载-使用GetRandomValue()方法选择一张牌调用另一
            //版本AskForACard方法叫牌
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
        }
        
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            //向其它玩家要牌
            //首先在TextBox中增加一行“乔伊问有人有Q吗？”
            //然后遍历玩家看是否有所叫点数（用DoYouHaveAny()方法）。
            //如果有的话，将牌传入你的手牌。keep track of how many cards were added
            //如果没有，你要从牌堆中抽一张牌。
            //关在TextBox 中增加一行：“乔伊不得不从牌堆中抽牌”
            string points;
            if ((int)value > 10)  points = value.ToString();
            else points = ((int)value).ToString();

            textBoxOnForm.Text += name + "叫牌：" + points + Environment.NewLine;
            int numberOfAsk = 0;
            foreach (Player p in players)
            {
                if (p.Equals(this)) continue;
                Deck getCards = p.DoYouHaveAny(value);
                if (getCards.Count == 0) continue;
                numberOfAsk += getCards.Count;
                textBoxOnForm.Text += name + "从" + p.name +"手中取得" +
                    getCards.Count + "张" + points + Environment.NewLine;
                while (getCards.Count != 0)
                    cards.Add(getCards.Deal());
            }
            if (numberOfAsk == 0 && stock.Count > 0){
                textBoxOnForm.Text += name + "不得不从牌堆中抽一张牌。" +
                    Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        //以下是已写好的小方法
        public int CardCount{ get{return cards.Count;}}
        
        //得到一张牌
        public void TakeCard(Card card) { cards.Add(card); }

        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }

        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }

        //将手中的牌排序
        public void SortHand() { cards.SortByValue(); }

        
    }

    //向Card类中追加方法
    public partial class Card
    {
        //public static string Plural(Values value)
        public static string returnPoints(Values value)
        {
            string points;
            if ((int)value > 10) points = value.ToString();
            else points = ((int)value).ToString();
            return points;
        }
    }
}
