using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;

        public int HitPoints { get; private set; }
    }
}
