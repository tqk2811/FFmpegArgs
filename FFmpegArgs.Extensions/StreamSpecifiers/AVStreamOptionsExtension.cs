namespace FFmpegArgs
{
    /// <summary>
    /// 
    /// </summary>
    public static class AVStreamOptionsExtension
    {
        /// <summary>
        /// Select an encoder (when used before an output file) or a decoder (when used before an input file) for one or more streams. codec is the name of a decoder/encoder or a special value copy (output only) to indicate that the stream is not to be re-encoded.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <returns></returns>
        public static T Codec<T>(this T t, string codec) where T : BaseAVStream // (input/output,per-stream)
           => t.SetOption("-c", codec);
    }
}
