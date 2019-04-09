using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.Classes
{
    public class Quagmire : Warrior
    {
        public override bool Human { get; set; } = true;
        public override bool Elf { get; set; } = false;
        public override bool Orc { get; set; } = false;
        public override bool DragonBorn { get; set; } = false;
        public override bool Pikachu { get; set; } = false;
        public override bool IsStrong { get; set; } = false;

        public override int Strike()
        {
            return 4;
        }

        public override int Devestate()
        {
            return 5;
        }
    }
}
