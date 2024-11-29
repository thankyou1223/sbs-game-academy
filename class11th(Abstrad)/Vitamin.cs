using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace class11th_Abstrad_
{
    internal class Vitamin
    {
        private int protein;


        public int Protein
        {
            get
            {
                
                  return protein; } 
            set
            {
                if (value >= 100)
                {
                    Console.WriteLine("Can't Get Value");
                }
                else
                {
                    protein = value;
                }
        }
    }
}
