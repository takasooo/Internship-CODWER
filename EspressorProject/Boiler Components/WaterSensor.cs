using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class WaterSensor
    {

        public bool IsWaterEmpty { get; private set; }

        public WaterSensor() 
        {
            IsWaterEmpty = true;
        }

        public FillWater()
        {
            IsWaterEmpty = false;
        }
    }
}
