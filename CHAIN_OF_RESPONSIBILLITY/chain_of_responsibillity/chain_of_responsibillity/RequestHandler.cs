using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibillity
{
    public abstract class RequestHandler : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public void SetNextHandler(IRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual void HandleRequest(string request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("No handler available for this request.");
            }
        }
    }
}
