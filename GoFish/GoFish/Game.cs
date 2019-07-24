using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GoFish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            //游戏开始的第一步-发牌，此方法只在游戏开始时被调用。
            //洗牌
            //为每位玩家发5张牌
            //用foreach循环调用每位玩家的PullOutBooks()
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
                foreach (Player p in players)
                    p.TakeCard(stock.Deal());
            foreach (Player p in players)
                PullOutBooks(p);            
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            //进行一轮游戏。参数是玩家选择的牌
            //取得牌的点数，然后遍历所有玩家调用AskForACard（）方法，
            //如果返回true，调用PullOUtBooks()方法，
            //整理人类玩家的手牌，检查牌堆是否还有牌
            //如果没有牌了，显示“无牌，游戏结束！”并返回true否则返回false
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardToAskFor);//continue...

            }
            //return true;


        }

        public bool PullOutBooks(Player player)
        {
            //Pull out一个玩家的套牌
            //如果手中没牌返回true，否则返回false
            //将套牌加入Books字典
            IEnumerable<Values> booksPulled = player.PullOutBooks();
            foreach (Values value in booksPulled)
                books.Add(value, player);
            if (player.CardCount == 0)
                return true;
            return false;

        }

        public string DescribeBooks()
        {
            //从Books字典中返回一串文本描述玩家拥有的套牌情况
            string description = "";
            foreach (var book in books)
                description += book.Value + " 取得套牌：" + book.Key 
                    + Environment.NewLine;
            return description;
        }
        //public string GetWinnerName()
        
        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }
        
        public string DescribePlayerHands()
        {
            //返回一串文本描述牌局
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + "有" + players[i].CardCount+
                    "张牌。" + Environment.NewLine; 
                
            }
            description += "牌堆还剩" + stock.Count + "张牌。";
            return description;

        }


    }
}
