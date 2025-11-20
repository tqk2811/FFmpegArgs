namespace FFmpegArgs.Inputs.Demuxers
{
    /// <summary>
    /// Dynamic Adaptive Streaming over HTTP demuxer.<br/>
    /// This demuxer presents all AVStreams found in the manifest.By setting the discard flags on AVStreams the caller can decide which streams to actually receive.Each stream mirrors the id and bandwidth properties from the &lt;Representation&gt; as metadata keys named &quot;id&quot; and &quot;variant_bitrate&quot; respectively.<br/>
    /// <see href="https://ffmpeg.org/ffmpeg-formats.html#dash-1"/>
    /// </summary>
    public class DashDemuxer : BaseDemuxer, IImage
    {
        internal DashDemuxer(BaseInput baseInput) : base(DemuxingFileFormat.dash, baseInput)
        {
        }

        /// <summary>
        /// 16-byte key, in hex, to decrypt files encrypted using ISO Common Encryption (CENC/AES-128 CTR; ISO/IEC 23001-7).
        /// </summary>
        public DashDemuxer CencDecryptionKey(string key)
            => this.SetOption("-cenc_decryption_key", key);
    }
    public static partial class DemuxerExtensions
    {
        public static DashDemuxer DashDemuxer<TInput>(this TInput input) where TInput : BaseInput, IImageInput
          => new DashDemuxer(input);
        public static TInput DashDemuxer<TInput>(this TInput input, Action<DashDemuxer> action) where TInput : BaseInput, IImageInput
        {
            if (action is null) throw new ArgumentNullException(nameof(action));
            DashDemuxer dashDemuxer = new DashDemuxer(input);
            action.Invoke(dashDemuxer);
            return input;
        }
    }
}
