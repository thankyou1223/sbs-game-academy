using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10th_추상_
{
    internal class Warrior : Character
    {
        internal class Warrior : Character
        {
            public Warrior()
            {
                healrh = 100;
                attack = 5;
                defense = 5;
            }

            public override void Skill()
            {
                Console.WriteLine("Short Blade");
            }
        }
    }
}
