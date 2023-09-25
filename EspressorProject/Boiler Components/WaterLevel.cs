using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class WaterLevel
    {

        Boiler boiler = new Boiler();
        IndicatorLight indicatorLight = new IndicatorLight();
        public void WaterLevelChecker()
        {
            if (boiler.currentWaterAmount < boiler.maxWaterAmount/2)
            {
                Console.WriteLine("Water level low. Please add water.");
                if (!indicatorLight.IsOn)
                {
                    indicatorLight.TurnOn();
                }
            }
        }
    }
}
