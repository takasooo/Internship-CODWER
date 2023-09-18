using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var wolf = new Carnivore("Lup", 40, new Animal.DimensionsEnum(1.5, 0.5, 0.7), 14);
            var sheep = new Herbivore("Oaie", 60, new Animal.DimensionsEnum(1.3, 0.7, 1.3), 4);
            var bear = new Omnivorous("Urs", 150, new Animal.DimensionsEnum(2, 1, 2), 13);
            wolf.Energy();

            var salad = new Plant(1, 0.02m);
            var ham = new Meat(2, 0.03m);

            wolf.IsEating(ham, 2);
            sheep.IsEating(salad, 3);
            bear.IsEating(ham, salad, salad, salad);

            wolf.IsRunning(200);
            sheep.IsRunning(200);
            bear.IsRunning(200);

        }
    }
}
