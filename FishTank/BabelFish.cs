using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class BabelFish : Fish
    {
        public BabelFish(string name) 
        {
            AmountOfFoodRequired = 0.3;
            Name = name;
        }
    }
}
