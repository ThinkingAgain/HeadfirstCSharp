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
    }
}
