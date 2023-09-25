using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class Boiler
    {

        public decimal currentWaterAmount = 0;
        public int maxWaterAmount = 10;
        public decimal filledWater;
        public int waterMaxTemperature = 100;

        private IndicatorLight indicatorLight = new IndicatorLight();

        public void FillWater(decimal filledWater)
        {
            this.filledWater = filledWater;

            if (filledWater + currentWaterAmount < maxWaterAmount)
            {
                currentWaterAmount += filledWater;
                if (indicatorLight.IsOn) { indicatorLight.TurnOff(); }
            } else
            {
                indicatorLight.TurnOn();
                Console.WriteLine("You wanna add to much water. You can add maximum" + (maxWaterAmount - currentWaterAmount) + " litres of water.");
            }
        }

        public void 
    }
}
