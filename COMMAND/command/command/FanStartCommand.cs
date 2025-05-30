using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class FanStartCommand : ICommand
    {
        private readonly Fan _fan;

        public FanStartCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.Start();
        }

        public void Undo()
        {
            _fan.Stop();
        }
    }
}
