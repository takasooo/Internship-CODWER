using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class WaterSensor
    {

        Boiler boiler = new Boiler();
        IndicatorLight indicatorLight = new IndicatorLight();
        public void NoWaterChecker()
        {
            if (boiler.currentWaterAmount == 0)
            {
                Console.WriteLine("No water in boiler. Please add water.");
                if (!indicatorLight.IsOn)
                {
                    indicatorLight.TurnOn();
                }
            }
        }
    }
}
