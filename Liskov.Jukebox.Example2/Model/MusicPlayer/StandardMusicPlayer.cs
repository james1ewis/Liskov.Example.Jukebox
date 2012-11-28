using System;
using Liskov.Jukebox.Example2.Model;
using System.Collections.Generic;

namespace Liskov.Jukebox.Example
{
    public class StandardMusicPlayer : IMusicPlayer
    {
        public void PlayTrack(string track)
        {
            Console.WriteLine(string.Format("Currently playing track {0}", track));
        }
    }
}
