using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int percent);
        int GetChannel();
        void SetChannel(int channel);
    }
}
