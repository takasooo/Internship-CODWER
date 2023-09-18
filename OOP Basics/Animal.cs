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
        public string Name { get; set; }
        public decimal Weight { get; private set; }
        public DimensionsEnum Dimensions { get; private set; }
        public decimal Speed { get; private set; }

        protected List<Food> Stomach { get; private set; } = new List<Food>();
        public readonly decimal foodQuantity;
        public static int animalCount = 0;




        public struct DimensionsEnum
        {
            public readonly decimal length, width, height;

            public DimensionsEnum(double length, double width, double height)
            {
                this.length = (decimal)length;
                this.width = (decimal)width;
                this.height = (decimal)height;
            }
        }

        public Animal(string name, decimal weight, DimensionsEnum dimensions, decimal speed)
        {
            this.Name = name;
            this.Weight = weight;
            this.Dimensions = dimensions;
            this.Speed = speed;
            animalCount++;
        }

        public void IsEating(params  Food[] food)
        {
            foreach (var f in food) IsEating(f, 1);
        }
        public void IsEating(Food food, int foodQuantity)
        {
            decimal foodMaxWeight = this.Weight / 8;
            decimal foodWeightToBe = //Stomach.DefaultIfEmpty().Sum(f => f.Weight) + 
                food.Weight * foodQuantity;

            if (foodWeightToBe <= foodMaxWeight)
            {
                for (int i = 0; i < foodQuantity; i++) Stomach.Add(food);
                Console.WriteLine(Name + " is eating " +food.GetType().Name);
            }
        }

        public abstract double Energy();

        public void IsRunning(decimal distance)
        {
            decimal time;


            time = distance / (Speed / Stomach.Sum(food => food.Energy));
            Console.WriteLine(Name + " is running for the distance of " + distance +" meters in " + time.ToString("#0.00") + " seconds");
        }
    }
}