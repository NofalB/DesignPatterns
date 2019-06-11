using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Single : IVinylSingle
    {
        public string Artist { get; set; }
        public int Ranking { get; set; }
        public string Title { get; set; }
        public Single(int ranking, string title, string artist)
        {
            Artist = artist;
            Ranking = ranking;
            Title = title;
        }

        public void Pause()
        {
            Console.WriteLine($"Pause single '{Title}, {Artist} ({Ranking})'");

        }

        public void Play()
        {
            Console.WriteLine($"Playing single '{Title}, {Artist} ({Ranking})'");
        }

        public void Stop()
        {
            Console.WriteLine($"Stop single '{Title}, {Artist} ({Ranking})'");

        }
        public override string ToString()
        {
            return "";
        }
    }
}
