using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class FancyMP3Display : IObserver
    {
        ISubject player;


        public void Update(Song song)
        {
            song.FancyDisplay();
        }

        public FancyMP3Display(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }
    }
}
