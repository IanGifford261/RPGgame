using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.Classes
{
    public abstract class Paladin
    {
        public abstract int Crush();
        public abstract int Heal();

        public virtual int Obliterate()
        {
            return 14000;
        }
    }
}
