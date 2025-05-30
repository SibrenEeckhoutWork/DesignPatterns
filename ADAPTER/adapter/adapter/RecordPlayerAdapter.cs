using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class RecordPlayerAdapter : IMusicPlayer
    {
        private RecordPlayer recordPlayer;

        public RecordPlayerAdapter(RecordPlayer recordPlayer)
        {
            this.recordPlayer = recordPlayer;
        }

        public void NextTrack()
        {
            recordPlayer.NextRecord();
        }

        public void Play()
        {
            recordPlayer.PlayRecord();
        }

        public void Stop()
        {
            recordPlayer.StopRecord();
        }
    }
}
