using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    class OverrideTest
    {
        public class Animals
        {
            public string name;
            protected decimal basePrice;
            public Animals(string name, decimal basePrice)
            {
                this.name = name;
                this.basePrice = basePrice;
            }
            public virtual decimal Calprice()
            {
                return basePrice;
            }
        }
        public class Pets : Animals
        {
            private decimal bonus;
            public Pets(string name, decimal basePrice, decimal bonus) : base(name, basePrice)
            {
                this.bonus = bonus;
            }
            public override decimal Calprice()
            {
                return basePrice + bonus;
            }
        }
    }
}
