/*
anlms AVOptions:
  order             <int>        ..F.A...... set the filter order (from 1 to 32767) (default 256)
  mu                <float>      ..F.A....T. set the filter mu (from 0 to 2) (default 0.75)
  eps               <float>      ..F.A....T. set the filter eps (from 0 to 1) (default 1)
  leakage           <float>      ..F.A....T. set the filter leakage (from 0 to 1) (default 0)
  out_mode          <int>        ..F.A....T. set output mode (from 0 to 3) (default o)
     i               0            ..F.A....T. input
     d               1            ..F.A....T. desired
     o               2            ..F.A....T. output
     n               3            ..F.A....T. noise
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// .SC anlms             AA->A      Apply Normalized Least-Mean-Squares algorithm to first audio stream.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#anlmf_002c-anlms
    /// </summary>
    public class AnlmsFilter : AudioToAudioFilter, ISliceThreading, ICommandSupport
    {
        internal AnlmsFilter(AudioMap audioMap, AudioMap second) : base("anlms", audioMap, second)
        {
            AddMapOut();
        }

        /// <summary>
        /// set the filter order (from 1 to 32767) (default 256)
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AnlmsFilter Order(int order)
            => this.SetOptionRange("order", order, 1, 32767);

        /// <summary>
        /// set the filter mu (from 0 to 2) (default 0.75)
        /// </summary>
        /// <param name="mu"></param>
        /// <returns></returns>
        public AnlmsFilter Mu(float mu)
            => this.SetOptionRange("mu", mu, 0, 2);

        /// <summary>
        /// set the filter eps (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="eps"></param>
        /// <returns></returns>
        public AnlmsFilter Eps(float eps)
           => this.SetOptionRange("eps", eps, 0, 1);

        /// <summary>
        /// set the filter leakage (from 0 to 1) (default 0)
        /// </summary>
        /// <param name="leakage"></param>
        /// <returns></returns>
        public AnlmsFilter Leakage(float leakage)
           => this.SetOptionRange("leakage", leakage, 0, 1);

        /// <summary>
        /// set output mode (from 0 to 3) (default o)
        /// </summary>
        /// <param name="outMode"></param>
        /// <returns></returns>
        public AnlmsFilter OutMode(AnlmsOutMode outMode)
            => this.SetOption("out_mode", outMode.GetEnumAttribute<NameAttribute>().Name);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AnlmsFilterExtensions
    {
        /// <summary>
        /// Apply Normalized Least-Mean-(Squares|Fourth) algorithm to the first audio stream using the second audio stream.<br></br>
        /// This adaptive filter is used to mimic a desired filter by finding the filter coefficients that relate to producing the least mean square of the error signal(difference between the desired, 2nd input audio stream and the actual signal, the 1st input audio stream).
        /// </summary>
        public static AnlmsFilter AnlmsFilter(this AudioMap audioMap, AudioMap second)
          => new AnlmsFilter(audioMap, second);
    }

    /// <summary>
    /// set output mode (from 0 to 3) (default o)
    /// </summary>
    public enum AnlmsOutMode
    {
        /// <summary>
        /// 
        /// </summary>
        [Name("i")]
        Input = 0,
        /// <summary>
        /// 
        /// </summary>
        [Name("d")]
        Desired = 1,
        /// <summary>
        /// 
        /// </summary>
        [Name("o")]
        Output = 2,
        /// <summary>
        /// 
        /// </summary>
        [Name("n")]
        Noise = 3
    }
}
