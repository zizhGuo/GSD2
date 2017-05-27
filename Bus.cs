using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    internal class Bus
    {
        static readonly DateTime globalStartTime;
        static Bus()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine("Static constructor sets global start time to {0}", globalStartTime.ToLongTimeString());
        }
        int RouteNumber { get; set; }
        public Bus(int routeNumber)
        {
            RouteNumber = routeNumber;
            Console.WriteLine("Bus{0} is created.", RouteNumber);
        }
        public void Drive()
        {
            TimeSpan timeSpan = DateTime.Now - globalStartTime;
            Console.WriteLine("{0} is starting its route {1.N2} minutes after global start time {2}", this.RouteNumber, timeSpan, globalStartTime);
        }

    }
}
