using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    internal class Suiker : Decoder
    {
        public Suiker(Cafe cafe) : base(cafe)
        {
        }

        public override string getDescription()
        {
            return this.koffie.getDescription() + " + suiker";
        }

        public override float getPrice()
        {
            return this.koffie.getPrice() + 0.8f;
        }
    }
}
