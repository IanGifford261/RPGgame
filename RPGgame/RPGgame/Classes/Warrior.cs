using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.Classes
{
    public abstract class Warrior : Race
    {
        public abstract int Strike();

        public virtual int Devestate()
        {
            return 9001;
        }
    }
}
