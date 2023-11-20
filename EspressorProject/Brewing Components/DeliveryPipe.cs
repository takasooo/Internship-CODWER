using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class DeliveryPipe
    {

        public void TakeWaterFromBoiler(Boiler boiler, PressureReliefValve pressureReliefValve) 
        {

            decimal takenAmountOfWater;

            if (pressureReliefValve.pressureReliefed == true)
            {

                takenAmountOfWater = boiler.currentWaterAmount - 300;
            }
        }

        public void AddWaterToReceptacle()
        {
         
            
        }
    }

    public class FilterAndReceptacle
    {

        public bool isReceptacleFull = true;
        public decimal currentCoffeeAmount; //g
        public int maxCoffeeAmount = 100; //g
        public decimal filledCoffee; //g
        public decimal doneCoffeeAmount; //ml

        public void WaterIsFiltering()
        {
            Console.WriteLine("The water goes through the filter.");
        }

        public void CoffeeIsMade()
        {
            Console.WriteLine("Coffee is brewing. Please wait!");
        }

        public void FillReceptacle(IndicatorLight indicatorLight)
        {
            if (!isReceptacleFull)
            {
                Console.WriteLine("Please fill the receptacle with coffee grounds.");
                indicatorLight.TurnOn();
            }
        }

        public void FillCoffeeGrounds(decimal filledCoffee, IndicatorLight indicatorLight)
        {
            this.filledCoffee = filledCoffee;

            if (filledCoffee + currentCoffeeAmount < maxCoffeeAmount && filledCoffee + currentCoffeeAmount > maxCoffeeAmount)
            {
                currentCoffeeAmount += filledCoffee;
                indicatorLight.TurnOff();
            }
            else
            {
                indicatorLight.TurnOn();
                Console.WriteLine("You wanna add to much coffee. You can add maximum" + (maxCoffeeAmount - currentCoffeeAmount) + " grams of coffee.");
            }
        }
    }
}
