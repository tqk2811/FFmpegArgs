using System;

namespace FFmpegArgs.Exceptions
{
    public class FilterException : Exception
    {
        public FilterException() { }

        public FilterException(string message) : base(message) { }
    }
}
