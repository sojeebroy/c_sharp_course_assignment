using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Ipod : RadioPlayerInterface
    {
        public void changeChannel()
        {
            Console.WriteLine("Channale is changed..!!");
        }

        public void retune(double frequency)
        {
            Console.WriteLine("Playing at : " + frequency + " fm frequency");
        }

        public void setVolume(int loudness)
        {
            Console.WriteLine("Sound level : " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("\nRadio is turning on....");
            Console.WriteLine("Radio is on.");

        }
    }
}
