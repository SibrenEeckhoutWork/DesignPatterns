using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class AcceptState : State
    {
        public AcceptState(VendingMachine machine) : base(machine)
        {
        }

        public override void Accept()
        {
            Console.WriteLine("You acceptet this purchase. Returning item an rest of the monney");
            this.machine.setState(new NoCoinState(this.machine));
        }

        public override void InsertCoin()
        {
            Console.WriteLine("Adding this to the monney");
        }

        public override void SelectProduct(string product)
        {
            Console.WriteLine("You already selected a product");
        }
    }
}
