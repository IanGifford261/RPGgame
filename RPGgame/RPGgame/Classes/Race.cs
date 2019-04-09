using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.Classes
{
   public abstract class Race
   {
        public abstract bool Human { get; set; }
        public abstract bool Elf { get; set; }
        public abstract bool Orc { get; set; }
        public abstract bool DragonBorn { get; set; }
        public abstract bool Pikachu { get; set; }
        public virtual bool IsStrong { get; set; }

    }
}
