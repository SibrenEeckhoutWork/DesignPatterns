using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibillity
{
    public class DirectorHandler : RequestHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Medium-Level Request")
            {
                Console.WriteLine("Director handled the request.");
            }
            else
            {
                Console.WriteLine("Director can't handle the request. Passing to the next handler.");
                base.HandleRequest(request);
            }
        }
    }
}
