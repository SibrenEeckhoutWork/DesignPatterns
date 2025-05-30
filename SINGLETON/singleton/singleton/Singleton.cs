using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class Singleton
    {
        private static Singleton _instance;

        // Lock object voor thread safety
        private static readonly object _lock = new object();

        // Private constructor om te voorkomen dat externe klassen nieuwe objecten maken
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        // Publieke methode om de enkele instantie te verkrijgen
        public static Singleton Instance
        {
            get
            {
                // Double-check locking voor thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // Voorbeeld van een methode die door de singleton kan worden aangeroepen
        public void DoSomething()
        {
            Console.WriteLine("Singleton method called.");
        }
    }
}
