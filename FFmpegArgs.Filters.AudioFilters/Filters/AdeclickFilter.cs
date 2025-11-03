/*
adeclick AVOptions:
  window            <double>     ..F.A...... set window size (from 10 to 100) (default 55)
  w                 <double>     ..F.A...... set window size (from 10 to 100) (default 55)
  overlap           <double>     ..F.A...... set window overlap (from 50 to 95) (default 75)
  o                 <double>     ..F.A...... set window overlap (from 50 to 95) (default 75)
  arorder           <double>     ..F.A...... set autoregression order (from 0 to 25) (default 2)
  a                 <double>     ..F.A...... set autoregression order (from 0 to 25) (default 2)
  threshold         <double>     ..F.A...... set threshold (from 1 to 100) (default 2)
  t                 <double>     ..F.A...... set threshold (from 1 to 100) (default 2)
  burst             <double>     ..F.A...... set burst fusion (from 0 to 10) (default 2)
  b                 <double>     ..F.A...... set burst fusion (from 0 to 10) (default 2)
  method            <int>        ..F.A...... set overlap method (from 0 to 1) (default add)
     add             0            ..F.A...... overlap-add
     a               0            ..F.A...... overlap-add
     save            1            ..F.A...... overlap-save
     s               1            ..F.A...... overlap-save
  m                 <int>        ..F.A...... set overlap method (from 0 to 1) (default add)
     add             0            ..F.A...... overlap-add
     a               0            ..F.A...... overlap-add
     save            1            ..F.A...... overlap-save
     s               1            ..F.A...... overlap-save
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TS. adeclick          A->A       Remove impulsive noise from input audio.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#adeclick
    /// </summary>
    public class AdeclickFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AdeclickFilter(AudioMap audioMap) : base("adeclick", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set window size, in milliseconds. Allowed range is from 10 to 100. Default value is 55 milliseconds.<br>
        /// </br> This sets size of window which will be processed at once.  (from 10 to 100) (default 55)
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public AdeclickFilter Window(double window)
          => this.SetOptionRange("w", window, 10, 100);
        /// <summary>
        /// Set window overlap, in percentage of window size. Allowed range is from 50 to 95. Default value is 75 percent.<br>
        /// </br> Setting this to a very high value increases impulsive noise removal but makes whole process much slower. (from 50 to 95) (default 75)
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AdeclickFilter Overlap(double overlap)
          => this.SetOptionRange("o", overlap, 50, 95);
        /// <summary>
        /// Set autoregression order, in percentage of window size.<br>
        /// </br> Allowed range is from 0 to 25. Default value is 2 percent.<br>
        /// </br> This option also controls quality of interpolated samples using neighbour good samples.<br>
        /// </br> (from 0 to 25) (default 2)
        /// </summary>
        /// <param name="arorder"></param>
        /// <returns></returns>
        public AdeclickFilter ArOrder(double arorder)
          => this.SetOptionRange("a", arorder, 0, 25);
        /// <summary>
        /// Set threshold value. Allowed range is from 1 to 100. <br>
        /// </br>Default value is 2. This controls the strength of impulsive noise which is going to be removed.<br>
        /// </br> The lower value, the more samples will be detected as impulsive noise.<br>
        /// </br> (from 1 to 100) (default 2)
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AdeclickFilter Threshold(double threshold)
          => this.SetOptionRange("t", threshold, 1, 100);
        /// <summary>
        /// Set burst fusion, in percentage of window size. Allowed range is 0 to 10.  Default value is 2.<br>
        /// </br> If any two samples detected as noise are spaced less than this value then any sample between those two samples will be also detected as noise.<br>
        /// </br> (from 0 to 10) (default 2)
        /// </summary>
        /// <param name="burst"></param>
        /// <returns></returns>
        public AdeclickFilter Burst(double burst)
          => this.SetOptionRange("b", burst, 0, 10);
        /// <summary>
        /// Set overlap method.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public AdeclickFilter Method(AdeclickMethod method)
          => this.SetOption("m", method.ToString().ToLowerInvariant());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AdeclickFilterExtension
    {
        /// <summary>
        /// Remove impulsive noise from input audio.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AdeclickFilter AdeclickFilter(this AudioMap audioMap) => new AdeclickFilter(audioMap);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AdeclickMethod
    {
        /// <summary>
        /// Select overlap-add method. Even not interpolated samples are slightly changed with this method.
        /// </summary>
        Add,
        /// <summary>
        /// Select overlap-save method. Not interpolated samples remain unchanged.
        /// </summary>
        Save
    }
}
