using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;


        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set { yearOfRelease = value; }
        }

        public int Duration
        {
            get { return durationInSeconds; }
            set { durationInSeconds = value; }
        }
        public MusicFile()
        {

        }
        public void musicInfo()
        {
            Console.WriteLine("Music name          :"+title);
            Console.WriteLine("Music artisrt name  :" + artist);
            Console.WriteLine("Music released year :" + yearOfRelease);
            Console.WriteLine("Music duration      :" + durationInSeconds +"secs\n");

        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;

            Console.WriteLine("Music name          :" + title);
            Console.WriteLine("Music artisrt name  :" + artist);
            Console.WriteLine("Music released year :" + yearOfRelease);
            Console.WriteLine("Music duration      :" + durationInSeconds + "secs\n");
        }
        public void changeTitle(string title)
        {
            this.title = title;
            Console.WriteLine("Title is changed..!!");
            Console.WriteLine("And the title is :"+title);
        }

    }
}
