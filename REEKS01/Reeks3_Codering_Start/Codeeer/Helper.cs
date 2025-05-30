using System;
using System.Collections.Generic;
using System.Text;

namespace Coderingen
{
    public class Helper
    {
        
        Dictionary<string, ICodering> coderingen;
      
        public Helper()
        {
            coderingen = new Dictionary<string, ICodering>();
            coderingen["Cijfer"] = new Cijfer();
            coderingen["Blok"] = new Blok();
            coderingen["Wissel"] = new Wissel();            
        }

        public string LeesType()
        {
            Console.WriteLine("Beschikbare coderingen: ");
            foreach (string t in coderingen.Keys)
            {
                Console.WriteLine("\t" + t);
            }
            Console.Out.Write("Geef gewenste codering: ");
            string type = Console.In.ReadLine();
            while (!coderingen.ContainsKey(type))
            {
                Console.Out.Write("!! Geef juist beschrijving: ");
                type = Console.In.ReadLine();
            }
            return type;
        }

        //kan ook met methode ICodering GeefCodering(string type)
        public ICodering this[string type]
        {
            get { return coderingen[type]; }
        }
      
    }
}