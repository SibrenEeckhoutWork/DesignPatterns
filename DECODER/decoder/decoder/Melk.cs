using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    internal class Melk : Decoder
    {

        public Melk(Cafe cafe) : base(cafe)
        {

        }

        public override string getDescription()
        {
            return this.koffie.getDescription() + " + melk";
        }

        public override float getPrice()
        {
            return this.koffie.getPrice() + 0.5f;
        }
    }
}
