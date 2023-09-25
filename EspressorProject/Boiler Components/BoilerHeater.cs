using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class BoilerHeater
    {
        public int temperature;
        public void HeatWater()
        {
            for (int i = 0; i <= 100; i+=20) 
            { 
                temperature = i;
                Console.WriteLine("Water heated for " + temperature + "%");
            }
        }
    }
}
