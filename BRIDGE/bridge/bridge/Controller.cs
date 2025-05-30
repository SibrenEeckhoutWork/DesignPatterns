using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    abstract class Controller
    {
        public Implementor implementor;
        public Controller(Implementor implementor) {
            this.implementor = implementor;
        } 

        public abstract void setVolume(int volume);

        public abstract void playMusic();

        public abstract void stopMusic();
    }
}
