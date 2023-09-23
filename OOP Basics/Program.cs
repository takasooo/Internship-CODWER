using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            wolf.IsEating(salad, 2);
            sheep.IsEating(salad, 3);
            bear.IsEating(ham, salad, salad, salad);

            wolf.IsRunning(200);
            sheep.IsRunning(200);
            bear.IsRunning(200);

            Console.WriteLine(new Carnivore("Rata", 30, new Animal.DimensionsEnum(0.5, 0.3, 0.4), 12));

            List<Animal> animalsList = new List<Animal>();
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                TypeAnimal randomAnimalType = (TypeAnimal)random.Next(0, 6);

                string animalName = "Animal " + i.ToString();
                decimal animalWeight = (decimal)(random.NextDouble() * 100);
                Animal.DimensionsEnum animalDimensions = new Animal.DimensionsEnum();
                decimal animalSpeed = (decimal)(random.NextDouble() * 20);

                Animal animal = CreateAnimal(randomAnimalType, animalName, animalWeight, animalDimensions, animalSpeed);
                animalsList.Add(animal);
            }

            int numberCarnivore = 0;
            int numberHerbivore = 0;
            int numberOmnivorous = 0;

            foreach (var animal in animalsList)
            {
                if (animal is Carnivore)
                {
                    Food meat = new Meat(0.5m, 0.03m);
                    animal.IsEating(meat);
                    numberCarnivore++;
                } 
                else if (animal is Herbivore)
                {
                    Food plant = new Plant(0.2m, 0.01m);
                    animal.IsEating(plant);
                    numberHerbivore++;
                }
                else if (animal is Omnivorous)
                {
                    Food meat = new Meat(0.5m, 0.03m);
                    Food plant = new Plant(0.2m, 0.01m);
                    animal.IsEating(plant, meat);
                    numberOmnivorous++;
                }
            }

            Console.WriteLine(numberCarnivore + " animals are carnivore and eat meat.");
            Console.WriteLine(numberHerbivore + " animals are herbivore and eat plant.");
            Console.WriteLine(numberOmnivorous + " animals are omnivourous and eat both meat and plant.");

        }

        public static Animal CreateAnimal(TypeAnimal typeAnimal, string name, decimal weight, Animal.DimensionsEnum dimensions, decimal speed)
        {
            switch (typeAnimal)
            {
                case TypeAnimal.Wolf:
                    return new Carnivore(name, weight, dimensions, speed);
                case TypeAnimal.Sheep:
                    return new Herbivore(name, weight, dimensions, speed);
                case TypeAnimal.Bear:
                    return new Omnivorous(name, weight, dimensions, speed);
                case TypeAnimal.Squirrel:
                    return new Omnivorous(name, weight, dimensions, speed);
                case TypeAnimal.Cat:
                    return new Carnivore(name, weight, dimensions, speed);
                case TypeAnimal.Cow:
                    return new Herbivore(name, weight, dimensions, speed);
                default:
                    throw new ArgumentException("The animal type is not recognised");
            }
        }

        public enum TypeAnimal
        {
            Wolf, Bear, Sheep, Squirrel, Cat, Cow
        }

    }
}
