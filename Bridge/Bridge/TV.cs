using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class TV : IDevice
    {
        public void Disable()
        {
            Console.WriteLine("TV is disabled!");
        }

        public void Enable()
        {
            Console.WriteLine("TV is enabled!");
        }

        public int GetChannel()
        {
            return 1;
        }

        public int GetVolume()
        {
            return 10;
        }

        public bool IsEnabled()
        {
            return false;
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Channel is set to " + channel);
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine("Channel is set to " + percent + " %");
        }
    }
}
