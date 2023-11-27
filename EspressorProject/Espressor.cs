using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class Espressor
    {
        private Boiler boiler;
        private BoilerHeater boilerHeater;
        private Pot pot;
        private PlateHeater plateHeater;
        private PressureReliefValve pressureReliefValve;
        private StartButton startButton;

        public Espressor()
        {
            boiler = new Boiler();
            boilerHeater = new BoilerHeater(boiler);
            pot = new Pot();
            plateHeater = new PlateHeater();
            pressureReliefValve = new PressureReliefValve();
            startButton = new StartButton();
        }

        public void StartBrewing()
        {
            if (pot.IsPotInPlace && boiler.GetCurrentWaterAmount() > 0)
            {
                startButton.Start();
                boilerHeater.HeatWater();
                pressureReliefValve.PressureRelief(boilerHeater);
                Console.WriteLine("Brewing started.");
            }
            else
            {
                Console.WriteLine("Ensure the pot is in place and the boiler has water.");
            }
        }

        public void StopBrewing()
        {
            Console.WriteLine("Brewing stopped.");
        }

        public void FillWater(decimal waterAmount)
        {
            boiler.FillWater(waterAmount);
        }

        public void PutInPot()
        {
            pot.InsertPot();
        }

        public void TakeOutPot()
        {
            pot.RemovePot();
        }

        public void HandleUserInput()
        {

            bool continueRunning = true;

            while (continueRunning) {

                Console.WriteLine("Espressor Control Panel");
                Console.WriteLine("Press 'F' to fill water, 'I' to insert pot, 'R' to remove pot, 'S' to start brewing, 'T' to stop brewing, 'Q' to quit.");
                char input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 'F':
                        Console.Write("Enter water amount to fill (in ml): ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal waterAmount))
                        {
                            FillWater(waterAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for water amount.");
                        }
                        break;
                    case 'I':
                        PutInPot();
                        break;
                    case 'R':
                        TakeOutPot();
                        break;
                    case 'S':
                        StartBrewing();
                        break;
                    case 'T':
                        StopBrewing();
                        break;
                    case 'Q':
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
