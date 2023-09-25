using System.Linq;

namespace OOP_Basics
{
    public class Carnivore : Animal
    {
        public Carnivore(string name, decimal weight, DimensionsEnum dimensions, decimal speed) : base(name, weight, dimensions, speed)
        {
        }
        public override double Energy()
        {
            return 0.2 - (1.0 / 5.0) * ((double)Stomach.Select(food => (double)food.Weight).DefaultIfEmpty().Average() + Stomach.Select(food => (double)food.Energy).DefaultIfEmpty().Sum());
        }

        public override bool CanEat(Food food)
        {
           return food is Meat;
        }
    }
}




