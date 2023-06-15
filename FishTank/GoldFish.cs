namespace FishTank
{
    public class GoldFish : Fish
    {
        public GoldFish(string name) 
        {
            AmountOfFoodRequired = 0.1; //this sets the required value for the fish of what is required for the fish class
            Name = name; //this does the same as the amount of food required but with a name
        }
    }
}