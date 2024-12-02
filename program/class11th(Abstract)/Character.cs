using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11th_Abstract_
{
    abstract class Character
    {
        protected int health;
        protected int attack;
        protected int defense;

        public void Stats()
        {
            Console.WriteLine("health : " + health);
            Console.WriteLine("defense : " + defense);
            Console.WriteLine("attack : " + attack);
        }

        public abstract void Skill();
    }
}
