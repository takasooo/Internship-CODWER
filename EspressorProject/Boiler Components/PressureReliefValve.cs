using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class PressureReliefValve
    {

        BoilerHeater boilerHeater = new BoilerHeater();

        public bool pressureReliefed = false;
        public void PressureRelief()
        {
            if (boilerHeater.temperature == 100)
            Console.WriteLine("The pressure has been reliefed successfully.");
            pressureReliefed = true;
        }
    }
}