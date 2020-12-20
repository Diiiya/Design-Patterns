using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            RemoteControl remoteControlOfRadio = new RemoteControl(radio);
            remoteControlOfRadio.TogglePower();
            remoteControlOfRadio.NextChannel();
            Console.WriteLine();

            Console.WriteLine("--------------");
        }
    }
}
