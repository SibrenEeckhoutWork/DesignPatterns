using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public class TemperatureDisplay : IObserver
    {
        private float _temperature;

        public void Update(float temperature)
        {
            _temperature = temperature;
            Display();
        }

        private void Display()
        {
            Console.WriteLine($"Current temperature is: {_temperature}°C");
        }
    }
}
