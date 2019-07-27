using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public abstract string Name { get; }
    }
}
