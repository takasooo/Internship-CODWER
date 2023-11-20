using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class Boiler
    {

        public decimal currentWaterAmount; //ml
        public int maxWaterAmount = 1000; //ml
        //public decimal filledWater; //ml
        public int waterMaxTemperature = 100; //Celsius

        private IndicatorLight indicatorLight = new IndicatorLight();
        private WaterLevel waterLevel;

        public Boiler()
        {
            waterLevel = new WaterLevel(this, indicatorLight);
        }

        public Boiler(decimal currentWaterAmount, int maxWaterAmount) : this()
        {
            this.currentWaterAmount = currentWaterAmount;
            this.maxWaterAmount = maxWaterAmount;
        }

        public void FillWater(decimal filledWater, WaterLevel waterLevel, IndicatorLight indicatorLight, Boiler boiler)
        {

            if (filledWater + currentWaterAmount < maxWaterAmount)
            {
                currentWaterAmount += filledWater;
                indicatorLight.TurnOff();
            } else
            {
                currentWaterAmount = maxWaterAmount;
                indicatorLight.TurnOn();
                Console.WriteLine("You wanna add to much water. You can add maximum" + (maxWaterAmount - currentWaterAmount) + " litres of water.");
            }
            waterLevel.WaterLevelChecker(indicatorLight, boiler);
        }
    }

    public class BoilerHeater
    {
        public int temperature;

        public void HeatWater()
        {
            for (int i = 0; i <= 100; i += 20)
            {
                temperature = i;
                Console.WriteLine("Water heated for " + temperature + "%");
            }
        }
    }

    public class PressureReliefValve
    {

        public bool pressureReliefed = false;

        public void PressureRelief(BoilerHeater boilerHeater)
        {
            if(boilerHeater.temperature == 100)
                Console.WriteLine("The pressure has been relieved successfully.");
            pressureReliefed = true;
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

        public void WaterLevelChecker(IndicatorLight indicatorLight, Boiler boiler)
        {
            if (boiler.currentWaterAmount < boiler.maxWaterAmount / 2)
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

            public void NoWaterChecker(IndicatorLight indicatorLight, Boiler boiler)
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
}
