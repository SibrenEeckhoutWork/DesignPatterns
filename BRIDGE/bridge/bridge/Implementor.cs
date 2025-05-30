using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal interface Implementor
    {
        public void playMusic();

        public void setVolume(int volume);

        public void stopMusic();
    }
}
