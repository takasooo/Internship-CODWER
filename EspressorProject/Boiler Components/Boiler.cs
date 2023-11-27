using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class Boiler
    {

        private decimal currentWaterAmount; //ml
        private int maxWaterAmount = 1000; //ml
        //public decimal filledWater; //ml
        private int waterMaxTemperature = 100; //Celsius

        private IndicatorLight indicatorLight = new IndicatorLight();
        private WaterLevel waterLevel;

        public Boiler()
        {
            waterLevel = new WaterLevel(this, indicatorLight);
        }

        public Boiler(decimal currentWaterAmount) : this()
        {
            this.currentWaterAmount = currentWaterAmount;
        }

        public void FillWater(decimal filledWater)
        {

            if (filledWater + currentWaterAmount < maxWaterAmount)
            {
                currentWaterAmount += filledWater;
                indicatorLight.TurnOff();
            } 
            else
            {
                currentWaterAmount = maxWaterAmount;
                indicatorLight.TurnOn();
                Console.WriteLine("You wanna add to much water. You can add maximum" + (maxWaterAmount - currentWaterAmount) + " litres of water.");
            }
            waterLevel.WaterLevelChecker();
        }

        public decimal GetCurrentWaterAmount()
        {
            return currentWaterAmount;
        }

        public decimal GetMaxWaterAmount()
        {
            return maxWaterAmount;
        }

        public int GetWaterMaxTemperature()
        {
            return waterMaxTemperature;
        }

        public IndicatorLight GetIndicatorLight()
        {
            return indicatorLight;
        }

        public WaterLevel GetWaterLevel()
        {
            return waterLevel;
        }
    }

    public class BoilerHeater
    {
        private int temperature;
        private Boiler boiler;

        public BoilerHeater(Boiler boiler)
        {
            this.boiler = boiler;
        }

        public void HeatWater()
        {
            temperature = 0;
            do
            {
                Console.WriteLine("Water heated for " + temperature + "%");
                temperature += 20;
            } while (temperature <= boiler.GetWaterMaxTemperature());
        }

        public int GetTemperature()
        {
            return temperature;
        }
    }

    public class PressureReliefValve
    {

        private bool pressureRelieved = false;

        public void PressureRelief(BoilerHeater boilerHeater)
        {
            if(boilerHeater.GetTemperature() == 100)

                Console.WriteLine("The pressure has been relieved successfully.");
                pressureRelieved = true;
        }

        internal void PressureRelief(Boiler boiler)
        {
            throw new NotImplementedException();
        }
    }

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
            if (boiler.GetCurrentWaterAmount() < boiler.GetMaxWaterAmount() / 2)
            {
                Console.WriteLine("Water level low. Please add water.");
                indicatorLight.TurnOn();
            }
            else
            {
                indicatorLight.TurnOff();
            }
        }

        public class WaterSensor
        {

            public void NoWaterChecker(Boiler boiler, IndicatorLight indicatorLight)
            {
                if (boiler.GetCurrentWaterAmount() == 0)
                {
                    Console.WriteLine("No water in boiler. Please add water.");
                }
            }
        }
    }
}
