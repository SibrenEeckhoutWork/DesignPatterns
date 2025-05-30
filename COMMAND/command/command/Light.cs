using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class Light
    {
        public Light() { }
        public void On()
        {
            Console.WriteLine("Light is ON");
        }

        public void Off()
        {
            Console.WriteLine("Light is OFF");
        }
    }
}
