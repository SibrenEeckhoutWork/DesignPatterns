using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestandsSysteem.Model
{
    abstract class File
    {
        public string name;
        public Folder Parent { get; set; } = null;
        public string PathName { get { return "path/to/folder"; } }
        abstract public string ListName { get; }
        public string Name { get { return name; } }
        public bool IsRoot { get { return true; } }

        public File(string name)
        {
            if (name == null) throw new FileSystemException("Invalid name.");
            if (name == "/") throw new FileSystemException("Invalid name.");
            this.name= name;
        }


    }
}
