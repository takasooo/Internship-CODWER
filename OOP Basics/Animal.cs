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
        private readonly Dimensions dimension;
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
            this.dimension = dimensions;
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

    public class Herbivore : Animal
    {
        public Herbivore(string name,  decimal weight, Dimensions dimensions, decimal speed) : base (name, weight, dimensions, speed)
        {
        }
        
        public override double Energy()
            f
        {
            return 0.5 + (1 / 3) * ((decimal)((float)stomach.Average(food => double)).weight)
        }
    }

    public class Omnivorous : Animal
    {
        public Herbivore(string name, decimal weight, Dimensions dimensions, decimal speed) : base(name, weight, dimensions, speed)
        {
        }
    }

    public class Carnivore : Animal
    {
        public Herbivore(string name, decimal weight, Dimensions dimensions, decimal speed) : base(name, weight, dimensions, speed)
        {
        }
        public override double Energy()
        {

        }
    }
}




