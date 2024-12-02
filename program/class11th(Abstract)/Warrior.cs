using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11th_Abstract_
{
    internal class Warrior : character
    {
        public Warrior()
        {
            health = 100;
            attack = 5;
            defense = 5;
        }

        public override void Skill()
        {
            Console.WriteLine("Short Blade");
        }
    }
}
