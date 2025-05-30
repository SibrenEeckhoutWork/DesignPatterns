using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    public abstract class User
    {
        protected IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void ReceiveMessage(string message);

        public abstract void SendMessage(string message);
    }
}
