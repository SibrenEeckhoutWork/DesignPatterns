using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    internal class Foto : IAlbum
    {
        public string Name { get; set; }
        public Foto(string name) {
            this.Name = name;
        }

        public void add(IAlbum album)
        {
            Console.WriteLine("Kan geen foto toe voegen aan een foto.");
        }

        public void remove(IAlbum album)
        {
            Console.WriteLine("Kan geen foto verwijderen in een foto.");
        }

        public void Show(int indentLevel = 0)
        {
            Console.WriteLine($"{new string('-', indentLevel * 2)} {Name}");
        }
    }
}
