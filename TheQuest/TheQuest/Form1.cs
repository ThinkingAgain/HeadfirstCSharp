using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(128, 90, 655, 221));
            game.NewLevel(random);
            UpdateCharacters();
            Player.Visible = true;
        }

        private void UpdateCharacters()
        {
            
            //更新玩家位置和显示点数的标签
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text =
                game.PlayerHitPoints.ToString();
            

            //定义显示敌人的变量
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            
            //更新敌人位置
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }
            bat.Visible = showBat;


            //更新武器PictureBox
            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
            }

            //设置各武器清单图标的Visible属性
            if (game.CheckPlayerInventory("Sword"))
            {
                hasSword.Visible = true;
                if (game.PlayerWeapons.Count() == 1)
                    hasSword.BorderStyle = BorderStyle.FixedSingle;
            }
            else hasSword.Visible = false;
            if (game.CheckPlayerInventory("Bow"))
            {
                hasBow.Visible = true;
                if (game.PlayerWeapons.Count() == 1)
                    hasSword.BorderStyle = BorderStyle.FixedSingle;
            }
            else hasBow.Visible = false;
            if (game.CheckPlayerInventory("Mace"))
            {
                hasMace.Visible = true;
                if (game.PlayerWeapons.Count() == 1)
                    hasSword.BorderStyle = BorderStyle.FixedSingle;
            }
            else hasMace.Visible = false;

            
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if(enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
             //   game.NewLevel(random);
            //    UpdateCharacters(); 
            }
        }

        private void hasSword_Click(object sender, EventArgs e)
        {

        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
         
            
            //Todo:game.move()
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }
    }
}
