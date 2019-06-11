using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Album : IVinylAlbum
    {
        public string Band { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Album(string title, string band, int year)
        {
            Title = title;
            Band = band;
            Year = year;
        }
        public void Pause()
        {
            Console.WriteLine($"Pause Album '{Title}, {Band} ({Year})'");

        }

        public void Play()
        {
            Console.WriteLine($"Playing Album '{Title}, {Band} ({Year})'");
        }

        public void Stop()
        {
            Console.WriteLine($"Stop Album '{Title}, {Band} ({Year})'");

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
