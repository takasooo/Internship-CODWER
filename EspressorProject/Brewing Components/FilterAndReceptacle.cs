using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class FilterAndReceptacle
    {

        IndicatorLight indicatorLight = new IndicatorLight();

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
            Console.WriteLine("");
        }

        public void FillReceptacle()
        {
            if(!isReceptacleFull)
            {
                Console.WriteLine("Please fill the receptacle with coffee grounds.");
                if (!indicatorLight.IsOn)
                {
                    indicatorLight.TurnOn();
                }
            }
        }

        public void FillCoffeeGrounds(decimal filledCoffee)
        {
            this.filledCoffee = filledCoffee;

            if (filledCoffee + currentCoffeeAmount < maxCoffeeAmount && filledCoffee + currentCoffeeAmount > maxCoffeeAmount)
            {
                currentCoffeeAmount += filledCoffee;
                if (indicatorLight.IsOn) { indicatorLight.TurnOff(); }
            }
            else
            {
                indicatorLight.TurnOn();
                Console.WriteLine("You wanna add to much coffee. You can add maximum" + (maxCoffeeAmount - currentCoffeeAmount) + " grams of coffee.");
            }
        }

    }
}
