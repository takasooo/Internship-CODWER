using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EspressorProject
{
    public class Pot
    {
        public bool potIsInPlace = true;

        public void TakeOutPot()
        {
            Console.WriteLine("You took out the pot.");
            potIsInPlace = false;
        }

        public void PutInPot()
        {
            Console.WriteLine("You put in the pot.");
            potIsInPlace = true;
        }
        //receives coffee and contains it; should have a weight so if its weight is 0 then the plate sensor reacts
    }

    public class PlateHeater
    {
        private Timer timer;

        public PlateHeater()
        {

            timer = new Timer(HeatPlate, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));
            //each 5 mins starts heating the plate for 2 mins and then turns off
        }

        public void HeatPlate(object state)
        {
            Console.WriteLine("Heating pot.");
            Thread.Sleep(TimeSpan.FromMinutes(2));
            Console.WriteLine("Pot is hot.");
        }
    }

    public class PlateSensor
    {

        public PlateSensor(Pot pot)
        {
            if (pot.potIsInPlace == false)
            {
                Console.WriteLine("Please put the pot on the plate!");
            }
        }
    }
}
