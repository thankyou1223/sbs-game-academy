using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace class11th_Abstract_
{
    internal class Wizard : Character 
    {
        public Warrior()
        {
            health = 75;
            attack = 10;
            defense = 1;
        }

        public override void Skill()
        {
            Console.WriteLine("Magic Attack");
        }
    }
}
