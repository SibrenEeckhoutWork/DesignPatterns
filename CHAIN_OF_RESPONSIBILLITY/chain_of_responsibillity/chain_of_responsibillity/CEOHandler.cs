using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibillity
{
    public class CEOHandler : RequestHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "High-Level Request")
            {
                Console.WriteLine("CEO handled the request.");
            }
            else
            {
                Console.WriteLine("CEO can't handle the request. No more handlers.");
                base.HandleRequest(request);
            }
        }
    }
}
