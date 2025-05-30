using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class HasCoinState : State
    {
        public HasCoinState(VendingMachine machine) : base(machine)
        {
        }

        public override void Accept()
        {
            Console.WriteLine("Please select item first.");
        }

        public override void InsertCoin()
        {
            Console.WriteLine("Adding this to the previous coins");
        }

        public override void SelectProduct(string product)
        {
            Console.WriteLine("Selecting product " + product);
            this.machine.setState(new AcceptState(this.machine));
        }
    }
}
