using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal interface IMusicPlayer
    {
        public void Play();
        public void Stop();
        public void NextTrack();
    }
}
