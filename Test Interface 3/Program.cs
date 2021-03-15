using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new MusicFile();
            m1.Title = "60's Love";
            m1.Artist = "Level five";
            m1.YearOfRelease = 2018;
            m1.Duration = 320;

            MusicFile m2 = new MusicFile();
            m2.Title = "Ghum";
            m2.Artist = "Odd Signeture";
            m2.YearOfRelease = 2019;
            m2.Duration = 243;
        

            Phone p1 = new Phone();
            p1.Switch(true);
            p1.play(true);
            p1.addMusic(m1);
            p1.setVolume(9);

            p1.playNext();
            p1.addMusic(m2);

            p1.playPrevious();
            p1.addMusic(m1);


            Ipod ip = new Ipod();
            ip.Switch(true);
            ip.retune(99.9);
            ip.setVolume(9);
            ip.changeChannel();
            ip.retune(89.8);
        }
    }
}
