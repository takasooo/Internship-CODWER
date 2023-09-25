using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class Boiler
    {

        public decimal currentWaterAmount; //ml
        public int maxWaterAmount = 1000; //ml
        public decimal filledWater; //ml
        public int waterMaxTemperature = 100; //Celsius

        private IndicatorLight indicatorLight = new IndicatorLight();

        public Boiler()
        {
        }

        public Boiler(decimal currentWaterAmount, int maxWaterAmount, decimal filledWater)
        {
            this.currentWaterAmount = currentWaterAmount;
            this.maxWaterAmount = maxWaterAmount;
            this.filledWater = filledWater;
        }

        public void FillWater(decimal filledWater)
        {
            this.filledWater = filledWater;

            if (filledWater + currentWaterAmount < maxWaterAmount && filledWater + currentWaterAmount > maxWaterAmount)
            {
                currentWaterAmount += filledWater;
                if (indicatorLight.IsOn) { indicatorLight.TurnOff(); }
            } else
            {
                indicatorLight.TurnOn();
                Console.WriteLine("You wanna add to much water. You can add maximum" + (maxWaterAmount - currentWaterAmount) + " litres of water.");
            }
        }


    }
}
