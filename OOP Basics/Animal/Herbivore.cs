using System.Linq;

namespace OOP_Basics
{
    public class Herbivore : Animal
    {
        public Herbivore(string name,  decimal weight, DimensionsEnum dimensions, decimal speed) : base (name, weight, dimensions, speed)
        {
        }
        
        public override double Energy()
        {
            return 0.5 + (1.0 / 3.0) * ((double)Stomach.Average(food => (double)food.Weight) + Stomach.Sum(food => (double)food.Energy));
        }

        public override bool CanEat(Food food)
        {
            return food is Plant;
        }
    }
}




