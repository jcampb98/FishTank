using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class AngelFish : Fish
    {
        public AngelFish(string name) 
        {
            AmountOfFoodRequired = 0.2;
            Name = name;
        }
    }
}
