using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Liskov.Jukebox.Example.Tests
{
    [TestFixture]
    public class JukeboxTests
    {
        [Test]
        public void example_of_some_client_code_that_uses_our_jukebox_model()
        {
            var playlist = new List<string> { "barry-white.mp3", "blahblah.mp3" };
            var player = new StandardMusicPlayer();

            var systemUnderTest = new Jukebox(playlist, player);

            systemUnderTest.PlayTracks();

            Assert.Pass("All tracks played");
        }

        [Test]
        public void another_example_of_some_client_code_that_uses_our_jukebox_model()
        {
            var playlist = new List<string> { "barry-white.m4a", "blahblah.mp3" };
            var player = new HighQualityMusicPlayer(new StandardMusicPlayer());

            var systemUnderTest = new Jukebox(playlist, player);

            systemUnderTest.PlayTracks();

            Assert.Pass("All tracks played");
        }
    }
}
