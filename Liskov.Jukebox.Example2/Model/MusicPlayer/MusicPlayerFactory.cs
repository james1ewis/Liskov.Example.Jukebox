using Liskov.Jukebox.Example;

namespace Liskov.Jukebox.Example2.Model
{
    public static class MusicPlayerFactory
    {
        public static IMusicPlayer Create(string trackQuality)
        {
            switch (trackQuality)
            {
                case "m4a":
                    return new HighQualityMusicPlayer(new StandardMusicPlayer());
                default:
                    return new StandardMusicPlayer();
            }
        }
    }
}
