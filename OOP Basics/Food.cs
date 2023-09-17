using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Food
    {
        public decimal weight;
        public decimal energy;
        public decimal maxEnergy = 0.05m;

        public Food(decimal weight, decimal energy)
        {
            this.weight = weight;
            if (energy >= 0 && energy <= 0.05m)
            {
                this.energy = energy;
            } else
            {
                throw new ArgumentException("Cantitatea energiei poate fi intre 0 si 0.05");
            }
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
