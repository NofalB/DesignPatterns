using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Song
    {
        string Name;
        string Artist;
        string Duration;


        public Song(string name, string artist, string duration )
        {
            Name = name;
            Artist = artist;
            Duration = duration;
        }
        //displays should be in Simple/Fancy MP3Display
        public void SimpleDisplay()
        {
            Console.WriteLine("Simple display: {0} - '{1}'", Artist, Name);
        }

        public void FancyDisplay()
        {
            Console.WriteLine("Fancy display: '{0}' by {1} {2}", Name,Artist,Duration);
        }

    }

}
