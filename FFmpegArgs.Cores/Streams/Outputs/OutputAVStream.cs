﻿namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class OutputAVStream : BaseAVStream,
        ICodec, ICodecEncoder,
        IStream, IOutputStream
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseMap BaseMap { get; }


        /// <summary>
        /// 
        /// </summary>
        internal OutputAVStream(BaseMap baseMap, int streamIndex) : base(streamIndex)
        {
            this.BaseMap = baseMap ?? throw new ArgumentNullException(nameof(baseMap));
            baseMap.OutputAVStream = this;
        }
    }
}
