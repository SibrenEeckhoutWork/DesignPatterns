using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    internal class SimpleController : Controller
    {
        public SimpleController(Implementor implementor) : base(implementor) { }
        public override void playMusic()
        {
            implementor.playMusic();
        }

        public override void setVolume(int volume)
        {
            implementor.setVolume(volume);
        }

        public override void stopMusic()
        {
            implementor.stopMusic();
        }
    }
}
