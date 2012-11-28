using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Liskov.Jukebox.Example.Tests
{
    [TestFixture]
    public class JukeboxTests2
    {
        [TestCase(1)]
        [TestCase(2)]
        public void PlayUserSelection(int userId)
        {
            var playlist = PlaylistRepository.GetById(userId);
            var player = PlayerFactory.Create(playlist);

            var jukebox = new Jukebox(playlist, player);

            jukebox.PlayTracks();
            
            Assert.Pass("All tracks played");
        }
    }


























    public static class PlaylistRepository
    {
        public static IEnumerable<string> GetById(int id)
        {
            var playlist = new List<string> { "barry-white.mp3", "blahblah.mp3" };

            if (id == 2)
                playlist.Add("something.m4a");

            return playlist;
        }
    }

    public static class PlayerFactory
    {
        public static IMusicPlayer Create(IEnumerable<string> playlist)
        {
            switch (playlist.Count())
            {
                case 3:
                    return new HighQualityMusicPlayer();
                default:
                    return new StandardMusicPlayer();
            }
        }
    }
}
