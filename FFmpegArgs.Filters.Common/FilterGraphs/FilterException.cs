namespace FFmpegArgs.Filters.FilterGraphs
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterException : Exception
    {
        internal FilterException() { }
        internal FilterException(string message) : base(message) { }
    }
}
