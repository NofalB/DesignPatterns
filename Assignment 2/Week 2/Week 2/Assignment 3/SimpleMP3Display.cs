using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class SimpleMP3Display : IObserver
    {
        ISubject player;

        public void Update(Song song)
        {
            song.SimpleDisplay();
        }
        
        public SimpleMP3Display(ISubject player)
        {
            this.player = player;
            player.AddObserver(this);
        }

    }
}
