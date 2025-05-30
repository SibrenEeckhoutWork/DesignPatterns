using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class Box : Implementor
    {
        public Box() { }
        public void playMusic()
        {
            Console.WriteLine("Play music out of box");
        }

        public void setVolume(int volume)
        {
            Console.WriteLine("set volume to: " + volume);
        }

        public void stopMusic()
        {
            Console.WriteLine("stop music from box");
        }
    }
}
