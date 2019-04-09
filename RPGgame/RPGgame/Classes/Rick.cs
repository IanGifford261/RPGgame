using System;
using System.Collections.Generic;
using System.Text;

namespace RPGgame.Classes
{
    public class Rick : Paladin
    {
        public override bool Human { get; set; } = false;
        public override bool Elf { get; set; } = false;
        public override bool Orc { get; set; } = false;
        public override bool DragonBorn { get; set; } = false;
        public override bool Pikachu { get; set; } = true;
        public override bool IsStrong { get; set; } = true;


        public override int Crush()
        {
            return 13589;
        }

        public override int Heal()
        {
            return 500;
        }

        public override int Obliterate()
        {
            return 12987;
        }
    }
}
