using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class Fan
    {
        public Fan() { }
        public void Start()
        {
            Console.WriteLine("Fan is RUNNING");
        }

        public void Stop()
        {
            Console.WriteLine("Fan is STOPPED");
        }
    }
}
