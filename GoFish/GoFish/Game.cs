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
            //players[0].SortHand();
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
                    p.TakeCard(stock.Deal(0));

            
        }
    }
}
