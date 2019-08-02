using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public abstract string Name { get; }

        public Weapon(Game game, Point location)
         :base(game, location){
                PickedUp = false;            
        }

        public void PickUpWeapon() { PickedUp = true; }

    }

    class Sword: Weapon
    {
        public override string Name { get { return "Sword"; } }
        public Sword(Game game, Point location) : base(game, location)
        { }
    }



}
