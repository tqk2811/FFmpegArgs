/*
asoftclip AVOptions:
  type              <int>        ..F.A....T. set softclip type (from -1 to 7) (default tanh)
     hard            -1           ..F.A....T.
     tanh            0            ..F.A....T.
     atan            1            ..F.A....T.
     cubic           2            ..F.A....T.
     exp             3            ..F.A....T.
     alg             4            ..F.A....T.
     quintic         5            ..F.A....T.
     sin             6            ..F.A....T.
     erf             7            ..F.A....T.
  threshold         <double>     ..F.A....T. set softclip threshold (from 1e-06 to 1) (default 1)
  output            <double>     ..F.A....T. set softclip output gain (from 1e-06 to 16) (default 1)
  param             <double>     ..F.A....T. set softclip parameter (from 0.01 to 3) (default 1)
  oversample        <int>        ..F.A...... set oversample factor (from 1 to 32) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC asoftclip         A->A       Audio Soft Clipper.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#asoftclip"/>
    /// </summary>
    public class AsoftclipFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AsoftclipFilter(AudioMap audioMap) : base("asoftclip", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set softclip type (from -1 to 7) (default tanh)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public AsoftclipFilter Type(AsoftclipType type)
            => this.SetOption("type", type);

        /// <summary>
        /// set softclip threshold (from 1e-06 to 1) (default 1)
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AsoftclipFilter Threshold(double threshold)
            => this.SetOptionRange("threshold", threshold, 1e-06, 1);

        /// <summary>
        /// set softclip output gain (from 1e-06 to 16) (default 1)
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
        public AsoftclipFilter Output(double output)
            => this.SetOptionRange("output", output, 1e-06, 16);

        /// <summary>
        /// set softclip parameter (from 0.01 to 3) (default 1)
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public AsoftclipFilter Param(double param)
            => this.SetOptionRange("param", param, 0.01, 3);

        /// <summary>
        /// set oversample factor (from 1 to 32) (default 1)
        /// </summary>
        /// <param name="oversample"></param>
        /// <returns></returns>
        public AsoftclipFilter Oversample(int oversample)
            => this.SetOptionRange("oversample", oversample, 1, 32);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsoftclipFilterExtensions
    {
        /// <summary>
        /// Apply audio soft clipping.<br>
        /// </br>Soft clipping is a type of distortion effect where the amplitude of a signal is saturated along a smooth curve, rather than the abrupt shape of hard-clipping.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#asoftclip"/>
        /// </summary>
        public static AsoftclipFilter AsoftclipFilter(this AudioMap audioMap)
          => new AsoftclipFilter(audioMap);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AsoftclipType
    {
        hard,
        tanh,
        atan,
        cubic,
        exp,
        alg,
        quintic,
        sin,
        erf
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
