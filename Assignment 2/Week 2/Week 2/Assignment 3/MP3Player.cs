using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class MP3Player : ISubject
    {
        public Song CurrentSong { get; private set; }
        public List<Song> songList;
        private List<IObserver> observersList;
        Random rnd;

        public void NextSong()
        {
//            Random rnd2 = new Random();
  //          Random rnd = new Random(rnd2.Next());

            int index= rnd.Next(songList.Count);
            CurrentSong =songList.ElementAt(index);
            foreach(IObserver observer in observersList)
            {
                observer.Update(CurrentSong);
            }
                
        }

        public MP3Player()
        {
            songList = new List<Song>();
            observersList = new List<IObserver>();
            Create_Playlist();
            rnd = new Random();
        }

        private void Create_Playlist()
        {
            Song s1 = new Song("Wish You Were Here", "Pink Floyd", "(3:12)");
            Song s2 = new Song("Dazed And Confused","Led Zeppelin","(4:00)");
            Song s3 = new Song("Billionaire", "Bruno Mars", "(3:33)");
            Song s4 = new Song("Rap God", "Eminem", "(3:45)");
            Song s5 = new Song("Old Town Road", "Billy Ray", "(2:45)");
            Song s6 = new Song("Wow", "Post Malone", "(3:15)");

            songList.Add(s1);
            songList.Add(s2);
            songList.Add(s3);
            songList.Add(s4);
            songList.Add(s5);
            songList.Add(s6);
        }
        
        public void AddObserver(IObserver observer)
        {
            observersList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observersList.Remove(observer);
        }

    }
}
