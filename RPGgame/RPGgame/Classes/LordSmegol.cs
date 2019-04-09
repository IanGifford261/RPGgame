using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.Classes
{
    public class LordSmegol : Warrior
    {       
        public override bool Human { get; set; } = false;
        public override bool Elf { get; set; } = false;
        public override bool Orc { get; set; } = true;
        public override bool DragonBorn { get; set; } = false;
        public override bool Pikachu { get; set; } = false;
        public override bool IsStrong { get; set; } = true;

        public override int Strike()
        {
            return 92;
        }

        public override int Devestate()
        {
            return 280;
        }
    }
}
