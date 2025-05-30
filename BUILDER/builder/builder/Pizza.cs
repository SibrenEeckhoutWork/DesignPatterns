using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class Pizza
    {
        public string Size { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Size: {Size}");
            sb.AppendLine($"Dough: {Dough}");
            sb.AppendLine($"Sauce: {Sauce}");
            sb.AppendLine($"Cheese: {Cheese}");
            sb.AppendLine("Toppings: " + (Toppings.Count > 0 ? string.Join(", ", Toppings) : "None"));
            return sb.ToString();
        }
    }
}
