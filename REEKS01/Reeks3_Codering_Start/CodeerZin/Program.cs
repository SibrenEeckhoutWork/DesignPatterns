using Coderingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeerZin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            string type = helper.LeesType();
            ICodering codering = helper[type];
            Console.Write("Geen een zin:");
            string zin = Console.ReadLine();
     
            Console.WriteLine("Gecodeerd: "+ codering.Codeer(zin));
            Console.ReadKey();

        }
    }
}
