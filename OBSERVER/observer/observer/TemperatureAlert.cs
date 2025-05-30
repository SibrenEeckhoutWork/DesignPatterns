using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public class TemperatureAlert : IObserver
    {
        private float _temperature;

        public void Update(float temperature)
        {
            _temperature = temperature;
            CheckAlert();
        }

        private void CheckAlert()
        {
            if (_temperature > 30.0f)
            {
                Console.WriteLine("Alert: Temperature is too high!");
            }
        }
    }
}
