using System;

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
