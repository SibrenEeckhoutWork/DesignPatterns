using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    abstract class State
    {
        public VendingMachine machine;

        public State(VendingMachine machine)
        {
            this.machine = machine;
        }

        public abstract void InsertCoin();
        public abstract void SelectProduct(string product);
        public abstract void Accept();
    }
}
