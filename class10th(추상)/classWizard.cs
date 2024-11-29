using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10th_추상_
{
    internal class Wizard : Character
    {
        internal class Wizard : Chatacter
        {
            public Wizard()
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

    
}
