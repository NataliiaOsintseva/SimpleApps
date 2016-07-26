using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Player : IPlayable, IRecodable
    {

        public void Play()
        {
            Console.WriteLine("Play songs");
        }

        public void Record()
        {
            Console.WriteLine("Record something");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause() from IPlayable");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop() from IPlayable");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause() from IRecodable");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop() from IRecodable");
        }
    }
}
