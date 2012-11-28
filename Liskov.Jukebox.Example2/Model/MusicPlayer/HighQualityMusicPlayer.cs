using System;

namespace Liskov.Jukebox.Example
{
    public class HighQualityMusicPlayer : IMusicPlayer
    {
        private readonly StandardMusicPlayer _standardPlayer;
        public HighQualityMusicPlayer(StandardMusicPlayer standardPlayer)
        {
            _standardPlayer = standardPlayer;
        }

        public void PlayTrack(string track)
        {
            if (TheTrackQualityIsM4a(track))
                Console.WriteLine(string.Format("Curently playing track {0}", track));
            else
                _standardPlayer.PlayTrack(track);
        }
        
        private bool TheTrackQualityIsM4a(string track)
        {
            return true;
        }
    }
}
