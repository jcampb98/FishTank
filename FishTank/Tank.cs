using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class Tank
    {
        public List<Fish> Fish;

        public Tank()
        {
            Fish = new List<Fish>(); //this adds the fish class to a list so it could be added
        }

        public void Add(Fish fish)
        {
            Fish.Add(fish); //this allows the user to add more fish with a name in the tank
        }

        public double Feed()
        {
            double answer = 0.0;

            Fish.ForEach(x => answer += x.AmountOfFoodRequired); //this for each loop, loops for the amount of food that is required for each fish in the tank and returns the answer

            return answer;
        }
    }
}
