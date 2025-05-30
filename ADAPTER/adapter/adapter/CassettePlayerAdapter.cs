using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class CassettePlayerAdapter : IMusicPlayer
    {
        private CassetePlayer cassetePlayer;
        public CassettePlayerAdapter(CassetePlayer cassete) {
            this.cassetePlayer = cassete;
        }
        public void NextTrack()
        {
            cassetePlayer.NextCassette();
        }

        public void Play()
        {
            cassetePlayer.PlayCassette();
        }

        public void Stop()
        {
            cassetePlayer.StopCassette();   
        }
    }
}
