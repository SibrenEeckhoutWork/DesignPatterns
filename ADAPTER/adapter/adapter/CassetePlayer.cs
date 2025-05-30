using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class CassetePlayer
    {
        public CassetePlayer()
        {

        }

        public void PlayCassette() { Console.WriteLine("Cassette player will start playing music."); }
        public void StopCassette() { Console.WriteLine("Cassette player will stop playing music."); }
        public void NextCassette() { Console.WriteLine("Cassette player will play next cassette."); }
    }
}
