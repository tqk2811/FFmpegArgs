namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMap
    {
        /// <summary>
        /// Name of map
        /// </summary>
        string MapName { get; }

        /// <summary>
        /// FilterGraph Content
        /// </summary>
        IFilterGraph FilterGraph { get; }

        /// <summary>
        /// This map is mapped to filter/output or not
        /// </summary>
        bool IsMapped { get; }

        /// <summary>
        /// This map is from input or not
        /// </summary>
#if NET5_0_OR_GREATER
        [MemberNotNullWhen(true, nameof(InputAVStream))]
#endif
        bool IsInput { get; }

        /// <summary>
        /// 
        /// </summary>
        int IndexOfInput { get; }

        /// <summary>
        /// 
        /// </summary>
        InputAVStream? InputAVStream { get; }
        
        /// <summary>
        /// 
        /// </summary>
        OutputAVStream? OutputAVStream { get; }
    }
}
