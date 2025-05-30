using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibillity
{
    public class ManagerHandler : RequestHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Low-Level Request")
            {
                Console.WriteLine("Manager handled the request.");
            }
            else
            {
                Console.WriteLine("Manager can't handle the request. Passing to the next handler.");
                base.HandleRequest(request);
            }
        }
    }
}
