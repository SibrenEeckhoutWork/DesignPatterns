using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderingen
{
    internal class Cijfer:ICodering 
    {
        public string Codeer(string zin)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < zin.Length; i++)
            {
                int code = zin[i];
                result.Append(code);
            }
           
            return result.ToString();
        }

    }
}
