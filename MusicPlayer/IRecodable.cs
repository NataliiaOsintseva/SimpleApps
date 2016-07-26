using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
