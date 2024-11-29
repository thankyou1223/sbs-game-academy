using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10th_추상_
{
    class Rogue : Character
    {
        internal class Rigue()
        {
            health = 80;
            attack = 15;
            defense = 2.5;     
        }

        public override void Skill()
        {
            Console.WriteLine("Sting");
        }
    }
    
}
