using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class RemoteControl
    {
        protected IDevice device;
        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled() == true)
            {
                device.Disable();
            } else
            {
                device.Enable();
            }
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);
        }
        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void NextChannel()
        {
            device.SetChannel(device.GetChannel() + 1);
        }

        public void PrevChannel()
        {
            device.SetChannel(device.GetChannel() - 1);
        }
    }
}
