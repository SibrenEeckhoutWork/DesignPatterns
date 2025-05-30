using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestandsSysteem.Model
{
    internal class TextFile : File
    {
        string text;
        public string Text { get; set; }
        public override string ListName { get { return name; } }

        public TextFile(string name, string text) : base(name)
        {
            this.text= text;
        }


    }
}
