using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    internal class Chocolade : Decoder
    {
        public Chocolade(Cafe cafe) : base(cafe)
        {
        }

        public override string getDescription()
        {
            return this.koffie.getDescription() + " + chocolade";
        }

        public override float getPrice()
        {
            return this.koffie.getPrice() + 1f;
        }
    }
}
