using System;

namespace Liskov.Jukebox.Example
{
    public class HighQualityMusicPlayer : IMusicPlayer
    {
        public void PlayTrack(string track)
        {
            if (TheTrackQualityIsM4a(track))
                Console.WriteLine(string.Format("Curently playing track {0}", track));
            else
                throw new TrackQualityNotSupportedException();
        }

        private bool TheTrackQualityIsM4a(string track)
        {
            return true;
        }
    }
}
