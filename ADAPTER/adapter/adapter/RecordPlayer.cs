using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter
{
    internal class RecordPlayer
    {
        public RecordPlayer() { }

        public void PlayRecord()
        {
            Console.WriteLine("Record player will start playing.");
        }

        public void StopRecord() { Console.WriteLine("Record player will stop playing."); }

        public void NextRecord() { Console.WriteLine("Record player will play next record."); }
    }
}
