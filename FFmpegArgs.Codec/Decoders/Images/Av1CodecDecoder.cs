/*
AV1 decoder AVOptions:
  -operating_point   <int>        .D.V....... Select an operating point of the scalable bitstream (from 0 to 31) (default 0)
*/
namespace FFmpegArgs.Codec.Decoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class Av1CodecDecoder : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public Av1CodecDecoder(ImageInputAVStream stream) : base(Codecs.av1, stream)
        {
        }

        /// <summary>
        /// Select an operating point of a scalable AV1 bitstream (0 - 31). Default is 0.
        /// </summary>
        /// <returns></returns>
        public Av1CodecDecoder OperatingPoint(int operating_point)
            => this.SetOptionRange("operating_point", operating_point, 0, 31);
    }

    public static partial class ImageDecoderExtensions
    {
        /// <summary>
        /// AOMedia Video 1 (AV1) decoder.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Av1CodecDecoder Av1Codec(this ImageInputAVStream stream)
            => new Av1CodecDecoder(stream);
        public static T Av1Codec<T>(this T stream, Action<Av1CodecDecoder> action) where T : ImageInputAVStream
        {
            action.Invoke(stream.Av1Codec());
            return stream;
        }
    }
}
