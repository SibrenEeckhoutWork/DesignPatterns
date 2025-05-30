using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class SecuritySystem
    {
        public SecuritySystem() { }
        public void Arm()
        {
            Console.WriteLine("Security system is armed.");
        }

        public void Disarm()
        {
            Console.WriteLine("Security system is disarmed.");
        }

        public void LockDoors()
        {
            Console.WriteLine("All doors are locked.");
        }

        public void UnlockDoors()
        {
            Console.WriteLine("All doors are unlocked.");
        }
    }
}
