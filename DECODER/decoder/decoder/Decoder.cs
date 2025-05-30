using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoder
{
    abstract class Decoder : Cafe
    {
        public Cafe koffie;
        public Decoder(Cafe cafe) { 
            this.koffie = cafe;
        }

        public abstract string getDescription();

        public abstract float getPrice();
    }
}
