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

        //public Values GetRandomValue()
        //public Deck DoYouHaveAny(Values value)
        //pulbic void AskForACard(List<Player> players, int myIndex, Deck stock)
        //public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)

        //以下是已写好的小方法
        //public int CardCount{ get{return cards.Count;}}
        
        //得到一张牌
        public void TakeCard(Card card) { cards.Add(card); }

        //public IEnumerable<string> GetCardNames()
        //public Card Peek(int cardNumber)
        //public void SortHand()

        
    }

    //向Card类中追加方法
    public partial class Card
    {
        //public static string Plural(Values value)
    }
}
