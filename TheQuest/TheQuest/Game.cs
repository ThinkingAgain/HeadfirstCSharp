using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        //方法定义

        public Game(Rectangle boundaries) {
            this.boundaries = boundaries;
            player = new Player(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70));
            
        }

        //public void Move(Direction directin, Random random)

        //public void Equip(string weaponName)

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        //public void HitPlayer(int maxDamage, Random random)

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left +
                random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top +
                random.Next(boundaries.Bottom / 10 - boundaries.Top / 10)
                * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                    };
                    WeaponInRoom = new Sword(this, 
                        GetRandomLocation(random));
                    break;
                    
            }
        }



    }
}
