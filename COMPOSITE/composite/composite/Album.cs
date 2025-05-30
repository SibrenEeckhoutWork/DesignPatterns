using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    internal class Album : IAlbum
    {
        public string Name { get; private set; }
        private List<IAlbum> _albums = new List<IAlbum>();

        public Album(string name)
        {
            Name = name;
        }

        public void add(IAlbum album)
        {
            if (!_albums.Exists(a => a.Name == album.Name))
            {
                _albums.Add(album);
            }
        }

        public void remove(IAlbum album)
        {
            _albums.Remove(album);
        }

        public void Show(int indentLevel = 0)
        {
            Console.WriteLine($"{new string('-', indentLevel * 2)} {Name}");
            foreach (var album in _albums)
            {
                album.Show(indentLevel + 1);
            }
        }
    }
}
