using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class IndicatorLight
    {
        private bool isOn = false;
        public void TurnOn()
        {
            Console.WriteLine("The indicator is ON.");
            isOn = true;
        }

        public void TurnOff() 
        {
            Console.WriteLine("The indicator is OFF.");
            isOn = false;
        }

        public bool IsOn
        {
            get { return IsOn; }
        }
    }
}
