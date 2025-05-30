using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade
{
    internal class SmartHomeFacade : ISmartHomeFacade
    {
        private Thermostat Thermostat;
        private Light Light;
        private SecuritySystem SecuritySystem;
        private MusicSystem MusicSystem;

        public SmartHomeFacade(Thermostat thermostat, Light light, SecuritySystem securitySystem, MusicSystem musicSystem)
        {
            Thermostat = thermostat;
            Light = light;
            SecuritySystem = securitySystem;
            MusicSystem = musicSystem;
        }

        public void ThuisModus()
        {
            Thermostat.SetTemperature(18);
            Light.On();
            SecuritySystem.UnlockDoors();
            MusicSystem.PlayMusic("Living");
        }

        public void WegModus()
        {
            Thermostat.SetTemperature(0);
            Light.Off();
            SecuritySystem.LockDoors();
            MusicSystem.StopMusic();
        }
    }
}
