using System;

namespace Liskov.Jukebox.Example
{
    public class TrackQualityNotSupportedException : Exception
    {
        public TrackQualityNotSupportedException() { }
        public TrackQualityNotSupportedException(string message) : base(message) { }
    }
}
