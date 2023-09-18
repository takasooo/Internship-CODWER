using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public abstract class Food
    {
        private const decimal maxEnergy = 0.05m;
        public decimal Weight { get; set; }
        private decimal energy;
        public decimal Energy
        {
            get { return energy; }
            set {
                if (value >= 0 && value <= maxEnergy)
                    this.energy = value;
                else
                    throw new ArgumentException("Cantitatea energiei poate fi intre 0 si 0.05");
            }
        }
        

        public Food(decimal weight, decimal energy)
        {
            this.Weight = weight;
            this.Energy = energy;
        }

    }

    public class Meat : Food
    {
        public Meat (decimal weight, decimal energy) : base (weight, energy)
        {

        }
    }

    public class Plant : Food
    {
        public Plant(decimal weight, decimal energy) : base(weight, energy)
        {

        }
    }
}
