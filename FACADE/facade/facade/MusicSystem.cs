using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class MusicSystem
    {
        public MusicSystem() { }
        public void PlayMusic(string location)
        {
            Console.WriteLine($"Playing music in {location}.");
        }

        public void StopMusic()
        {
            Console.WriteLine("Music stopped.");
        }
    }
}
