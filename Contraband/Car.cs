using System;
using System.Collections.Generic;
using System.Text;

namespace Contraband
{
    class Car
    {
        public Random generator = new Random();

        public int passenger;
        public int contrabandAmount;
        public bool alredyChecked;

        public bool Examine()
        {
            alredyChecked = true;

            if (contrabandAmount <= 0)
            {
                return false;
            }
            else
            {
                return true;
                
            }
        }
    }
}
