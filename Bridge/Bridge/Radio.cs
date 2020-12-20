using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Radio : IDevice
    {
        public void Disable()
        {
            Console.WriteLine("Radio is disabled!");
        }

        public void Enable()
        {
            Console.WriteLine("Radio is enabled!");
        }

        public int GetChannel()
        {
            return 1;
        }

        public int GetVolume()
        {
            return 5;
        }

        public bool IsEnabled()
        {
            return false;
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Station is set to " + channel);
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine("Volume is set to " + percent + " %");
        }
    }
}
