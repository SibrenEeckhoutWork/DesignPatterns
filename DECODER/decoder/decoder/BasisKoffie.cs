using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    internal class BasisKoffie : Cafe
    {
        private float cost = 1;
        private string name; 

        public BasisKoffie(string name) {
            this.name = name;
        }
        public string getDescription()
        {
            return name;
        }

        public float getPrice()
        {
            return cost;
        }
    }
}
