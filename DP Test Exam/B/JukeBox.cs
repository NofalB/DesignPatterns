using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class JukeBox
    {

        public List<IVinylSingle> Singles { get; set; }
        public IVinylSingle Currentsingle { get; set; }
        public JukeBox(List<IVinylSingle> singles)
        {
            Singles = singles;
        }
        public void AddAlbum(List<IVinylSingle> albums)
        {
            foreach (IVinylSingle single in albums)
            {
                Singles.Add(single);

            }
        }
   
        public void SelectSingle(int index)
        {
            Currentsingle = Singles[index];
        }
        public void Play()
        {
            Currentsingle.Play();
        }
        public void Stop()
        {
            Currentsingle.Stop();
        }
    }
}
