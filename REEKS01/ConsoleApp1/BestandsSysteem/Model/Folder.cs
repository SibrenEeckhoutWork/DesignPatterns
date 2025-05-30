using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BestandsSysteem.Model
{
    internal class Folder : File
    {
        public HashSet<File> files;
        public Folder(string name) : base(name) 
        { 
        }
        public override string ListName { get { return name + "/"; } }
        public string Name { get { return name; } }

        public File? GetFile(string name)
        {
            foreach (var file in files)
            {
                if(file.Name == name) return file;
            }
            return null;
        }

        private File CreateFileInternal(string name, Func<string, File> fileConstructor)
        {
            if (string.IsNullOrEmpty(name) || GetFile(name) != null)
            {
                File file = fileConstructor(name);
                files.Add(file);
                return file;
            }
            throw new FileSystemException("File name not valid");
        }

        public File CreateTextFile(string name)
        {
            return CreateFileInternal(name, (n) => new TextFile(n, ""));
        }

        public File CreateFolder(string name)
        {
            return CreateFileInternal(name, (n) => new Folder(n));
        }

        public string PrintList()
        {
            string returnText = string.Empty;
            foreach (var file in files)
            {
                if(file is Folder)
                {
                    returnText += file.Name + "/" + "/\n";
                }
                else
                {
                    returnText += file.Name + "/\n";
                }
            }
            return "";
        }

        public string PrintTree()
        {
            string returnText = string.Empty;

            return returnText;
        }

    }
}
