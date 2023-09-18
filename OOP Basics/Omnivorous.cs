using System.Linq;

namespace OOP_Basics
{
    public class Omnivorous : Animal
    {
        public Omnivorous(string name, decimal weight, DimensionsEnum dimensions, decimal speed) : base(name, weight, dimensions, speed)
        {
        }

        public override double Energy()
        {
            decimal weightCoef = Stomach.Any() && Stomach[0] is Plant ? 0.5m : -0.5m;
            return 0.35 + (double) weightCoef * ((double)Stomach.Average(food => (double)food.Weight) + Stomach.Sum(food => (double)food.Energy));
        }
    }
}




