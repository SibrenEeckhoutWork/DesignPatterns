using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class ModerMusicPlayer : IMusicPlayer
    {
        public void NextTrack()
        {
            Console.WriteLine("Modern music player will play next track.");
        }

        public void Play()
        {
            Console.WriteLine("Modern music player will play music.");
        }

        public void Stop()
        {
            Console.WriteLine("Modern music player will stop playing.");
        }
    }
}
