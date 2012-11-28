using System.Collections.Generic;

namespace Liskov.Jukebox.Example
{
    public class Jukebox : IEnumerable<string>
    {
        private readonly IEnumerable<string> _playlist;
        private readonly IMusicPlayer _player;

        public Jukebox(IEnumerable<string> playlist, IMusicPlayer player)
        {
            _playlist = playlist;
            _player = player;
        }

        public void PlayTracks()
        {
            foreach (var track in _playlist)
            {
                _player.PlayTrack(track);
            }
        }
    }
}
