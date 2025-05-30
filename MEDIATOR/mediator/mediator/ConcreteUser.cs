using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    public class ConcreteUser : User
    {
        private readonly string _name;

        public ConcreteUser(string name)
        {
            _name = name;
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} received: {message}");
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{_name} sends: {message}");
            _mediator.SendMessage(message, this);
        }
    }
}
