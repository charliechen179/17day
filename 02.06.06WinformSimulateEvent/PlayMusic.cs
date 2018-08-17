using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02._06._06WinformSimulateEvent
{
    public delegate void DelPlayOver();
    class PlayMusic
    {
        public DelPlayOver Del;
        public string Name { get; set; }

        public PlayMusic(string name)
        {
            this.Name = name;
        }

        public void PlaySong()
        {
            Console.WriteLine("Playing"+this.Name);
            Thread.Sleep(3000);
            if (Del!=null)
            {
                Del();
            }
        }
    }
}
