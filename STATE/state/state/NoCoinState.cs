using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class NoCoinState : State
    {
        public NoCoinState(VendingMachine machine) : base(machine)
        {
        }

        public override void Accept()
        {
            Console.WriteLine("No coins inserted yet.");
        }

        public override void InsertCoin()
        {
            Console.WriteLine("Coins accepted. Please select item.");
            this.machine.setState(new HasCoinState(this.machine));
        }

        public override void SelectProduct(string product)
        {
            Console.WriteLine("No coins inserted yet");
        }
    }
}
