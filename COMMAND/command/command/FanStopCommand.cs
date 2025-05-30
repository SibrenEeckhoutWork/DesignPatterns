using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class FanStopCommand : ICommand
    {
        private readonly Fan _fan;

        public FanStopCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.Stop();
        }

        public void Undo()
        {
            _fan.Start();
        }
    }
}
