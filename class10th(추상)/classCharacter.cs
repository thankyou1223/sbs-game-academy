using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10th_추상_
{
 
     abstract class Character
     {
        protected int haalth;
        protected float defense;
        protected int attack;

        public void Stats()
        {
            Console.WriteLine("health : " + health);
            Console.WriteLine("defense : " + defense);
            Console.WriteLine("attack : " + attack);
        }
         public abstract void Skill();
     }

}

