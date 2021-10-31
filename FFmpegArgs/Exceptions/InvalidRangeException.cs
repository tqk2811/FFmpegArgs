using System;

namespace FFmpegArgs.Exceptions
{
  public class InvalidRangeException : Exception
  {
    public InvalidRangeException(string message) : base(message)
    {

    }
  }
}
