using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using Liskov.Jukebox.Example2.Model;

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
            var player = MusicPlayerFactory.Create(GetHighestQualityFromPlaylist(playlist));

            var jukebox = new Jukebox(playlist, player);

            jukebox.PlayTracks();
            
            Assert.Pass("All tracks played");
        }

        private string GetHighestQualityFromPlaylist(IEnumerable<string> playlist)
        {
            if (playlist.Count() == 3)
                return "m4a";

            return "mp3";
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
}
