using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);                
                return names;
            }
        }

        //方法定义：

        public Player(Game game, Point location)
            : base(game, location)
        {
            HitPoints = 10;            
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            
            if (!game.WeaponInRoom.PickedUp)
            {
                //如果武器在附近，将其增加至武器清单中
                //如果玩家还未装备武器，就立即装备这个武器
                if (Nearby(game.WeaponInRoom.Location, 50))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                    if (equippedWeapon == null)
                        Equip(game.WeaponInRoom.Name);

                }
            }
        }


    }
}
