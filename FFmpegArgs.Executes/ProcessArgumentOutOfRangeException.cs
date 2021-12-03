using System;

namespace FFmpegArgs.Executes
{
    public class ProcessArgumentOutOfRangeException : Exception
    {
        public ProcessArgumentOutOfRangeException(string message) : base(message)
        {

        }
    }
}
