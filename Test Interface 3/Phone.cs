using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Phone : MusicPlayerInterface
    {
        public MusicFile[] listOfMusic = new MusicFile[500];
        public int totalMusic;

        public Phone()
        {
            totalMusic = 0;
        }
        public void SetMusicList(int l)
        {
            Object[] listOfMusic = new object[l];
        }
        public void addMusic(MusicFile music)
        {
            if(totalMusic<listOfMusic.Count())
            {
                totalMusic++;
                this.listOfMusic[totalMusic] = music;
                Console.WriteLine("\nplaying         :" + music.Title);
                Console.WriteLine("Artist name     :" + music.Artist);
                Console.WriteLine("Duration        :" + music.Duration +" seconds");
                Console.WriteLine("Year in relased :" + music.YearOfRelease + "\n");


            }
            else
            {
                Console.WriteLine("Failed");
            }
            

        }
        public void play(bool on)
        {
            Console.WriteLine("Playing Music...");
        }

        public void playNext()
        {
            Console.WriteLine("Playing next track...");
        }

        public void playPrevious()
        {
            Console.WriteLine("Playing previous track...");
        }

        public void setVolume(int loudness)
        {
            Console.WriteLine("Sound level : " +loudness );
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Phone is on....");
        }
    }
}
