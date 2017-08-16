using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    public class Animals
    {
        public virtual void M1()
        {
            Console.WriteLine("base: M1");
        }
        public virtual void M2()
        {
            Console.WriteLine("base: M2");
        }
    }
    public class Pets : Animals
    {
        public override void M1()
        {
            Console.WriteLine("derived: M1");
        }
        public new void M2()
        {
            Console.WriteLine("derived: M2");
        }
    }
}
