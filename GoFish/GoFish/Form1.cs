using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonStart.Enabled = true;
            textName.Enabled = true;
        }

        private Game game; //窗体只与这个类交互，它要运行整个游戏。

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("请输入你的名字", "还不能开始游戏");
                return;
            }
            game = new Game(textName.Text, new List<string> { "乔伊", "鲍勃" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();

        }

        private void UpdateForm()
        {
            //在Listbox中显示玩家手中的牌
            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();

        }

        //private void buttonAsk_Click(object sender, EventArgs e)

    }
}
















