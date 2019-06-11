using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class SingleAdapter : IVinylSingle
    {
        IVinylAlbum album;
        public SingleAdapter(IVinylAlbum album)
        {
            this.album = album;
        }
        public void Pause()
        {
            album.Pause();
        }

        public void Play()
        {
            album.Play();
        }

        public void Stop()
        {
            album.Stop();
        }
    }
}
