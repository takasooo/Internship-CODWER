using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class DeliveryPipe
    {
        
        Boiler boiler = new Boiler();
        PressureReliefValve pressureRelief = new PressureReliefValve();

        public void TakeWaterFromBoiler() 
        {

            decimal takenAmountOfWater;

            if (pressureRelief.pressureReliefed == true)
            {

                takenAmountOfWater = boiler.currentWaterAmount - 300;
            }
        }

        public void AddWaterToReceptacle()
        {

        }
    }
}
