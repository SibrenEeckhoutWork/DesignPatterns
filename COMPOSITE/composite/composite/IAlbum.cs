using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    internal interface IAlbum
    {
        string Name { get; }
        public void add(IAlbum album);
        public void remove(IAlbum album);
        void Show(int indentLevel = 0);
    }
}
