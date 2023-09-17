using OOP_Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public abstract class Animal
    {
        public string name;
        public readonly decimal weight;
        private readonly Dimensions dimensions;
        protected List<Food> stomach = new List<Food>();
        public readonly decimal speed;



        public struct Dimensions
        {
            public readonly decimal length, width, height;

            public Dimensions(decimal length, decimal width, decimal height)
            {
                this.length = length;
                this.width = width;
                this.height = height;
            }
        }

        public Animal(string name, decimal weight, Dimensions dimensions, decimal speed)
        {
            this.name = name;
            this.weight = weight;
            this.dimensions = dimensions;
            this.speed = speed;
        }

        public void IsEating(Food food)
        {
            decimal foodMaxWeight = weight / 8;

            if (food.weight <= foodMaxWeight)

                stomach.Add(food);
            Console.WriteLine("Is eating.");

        }

        public abstract double Energy();

        public void IsRunning(Food food, decimal distance)
        {
            decimal time;


            time = (distance / (speed / food.energy));
            Console.WriteLine("The distance will be traveled in " + time + "seconds");
        }
    }

    public class Carnivore : Animal
    {
        public Carnivore(string name, decimal weight, Dimensions dimensions, decimal speed, Food food) : base(name, weight, dimensions, speed)
        {
        }
        public override double Energy()
        {
            return 0.2 - (1.0 / 5.0) * ((double)stomach.Average(food => (double)food.weight) + stomach.Sum(food => (double)food.energy));
        }
    }

    public class Herbivore : Animal
    {
        public Herbivore(string name,  decimal weight, Dimensions dimensions, decimal speed, Food food) : base (name, weight, dimensions, speed)
        {
        }
        
        public override double Energy()
        {
            return 0.5 + (1.0 / 3.0) * ((double)stomach.Average(food => (double)food.weight) + stomach.Sum(food => (double)food.energy));
        }
    }

    public class Omnivorous : Animal
    {
        public Omnivorous(string name, decimal weight, Dimensions dimensions, decimal speed, Food food) : base(name, weight, dimensions, speed)
        {
        }

        public override double Energy()
        {
            decimal weightCoef = stomach[0] is Plant ? 0.5m : -0.5m;
            return 0.35 + (double) weightCoef * ((double)stomach.Average(food => (double)food.weight) + stomach.Sum(food => (double)food.energy));
        }
    }
}




