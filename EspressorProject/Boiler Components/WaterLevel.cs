using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class WaterLevel
    {
        private Boiler boiler;
        private IndicatorLight indicatorLight;
        public WaterLevel(Boiler boiler, IndicatorLight indicatorLight)
        {
            this.boiler = boiler;
            this.indicatorLight = indicatorLight;
        }
        public void WaterLevelChecker()
        {
            if (boiler.currentWaterAmount < boiler.maxWaterAmount / 2)
            {
                Console.WriteLine("Water level low. Please add water.");
                indicatorLight.TurnOn();
            }
            else if (boiler.currentWaterAmount == boiler.maxWaterAmount)
            {
                Console.WriteLine("Water level low. Please add water.");
                indicatorLight.TurnOn();
            }
            else
            {
                indicatorLight.TurnOff();
            }
        }
    }
}
