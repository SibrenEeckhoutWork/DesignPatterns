using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    [Serializable]
    public class Tree : IPrototype<Tree>
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        // Constructor
        public Tree(string type, int age, string color)
        {
            Type = type;
            Age = age;
            Color = color;
        }

        // Shallow Copy (Clone method)
        public Tree Clone()
        {
            return (Tree)this.MemberwiseClone();
        }

        // Deep Copy (Serialization/Deserialization)
        public Tree DeepClone()
        {
            // Create a memory stream
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Create a new BinaryFormatter
                IFormatter formatter = new BinaryFormatter();

                // Serialize the current object into the memory stream
                formatter.Serialize(memoryStream, this);

                // Reset the memory stream position
                memoryStream.Seek(0, SeekOrigin.Begin);

                // Deserialize a new object from the memory stream
                return (Tree)formatter.Deserialize(memoryStream);
            }
        }

        public override string ToString()
        {
            return $"Type: {Type}, Age: {Age}, Color: {Color}";
        }
    }
}
