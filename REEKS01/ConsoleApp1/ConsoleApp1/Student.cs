using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public int inschrijvingsNummer;

        public Student(string name, int inschrijvingsNummer) : base(name)
        {
            this.inschrijvingsNummer = inschrijvingsNummer;
        }

        public override string WelcomeMessage {get { return "Hello" + name; }
        }
    }
}
