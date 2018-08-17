using System;
using System.Threading;

namespace _02._06._08EssentialOfEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayMusic p = new PlayMusic("Cool!");
            p.DelPlayOver += P_DelPlayOver;
            p.PlaySongs();
            Console.ReadKey();
        }

        private static void P_DelPlayOver(object sender, EventArgs e)
        {
            PlayMusic p = sender as PlayMusic;
            Console.WriteLine(p.Name+"Playing Done!");
        }
    }

    class PlayMusic
    {
        public event EventHandler DelPlayOver;
        public PlayMusic(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void PlaySongs()
        {
            Console.WriteLine("Playing"+this.Name);
            Thread.Sleep(3000);
            if (DelPlayOver!=null)
            {
                EventArgs e = new EventArgs();
                DelPlayOver(this, e);
            }
        }
    }
}
