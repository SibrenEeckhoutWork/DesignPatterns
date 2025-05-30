using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    internal class VendingMachine
    {
        private State state { get; set; }

        public VendingMachine()
        {
            this.state = new NoCoinState(this);
        }

        public void setState(State state) { this.state = state; }

        public void InsertCoin()
        {
            state.InsertCoin();
        }
        public void SelectProduct(string product)
        {
            state.SelectProduct(product);
        }
        public void Accept()
        {
            state.Accept();
        }
    }
}
