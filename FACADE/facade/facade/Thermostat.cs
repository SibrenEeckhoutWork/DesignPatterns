using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class Thermostat
    {
        public Thermostat() { }
        public void SetTemperature(int temperature)
        {
            Console.WriteLine($"Thermostat is set to {temperature} degrees.");
        }
    }
}
