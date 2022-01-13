/*
adeclip AVOptions:
  window            <double>     ..F.A...... set window size (from 10 to 100) (default 55)
  w                 <double>     ..F.A...... set window size (from 10 to 100) (default 55)
  overlap           <double>     ..F.A...... set window overlap (from 50 to 95) (default 75)
  o                 <double>     ..F.A...... set window overlap (from 50 to 95) (default 75)
  arorder           <double>     ..F.A...... set autoregression order (from 0 to 25) (default 8)
  a                 <double>     ..F.A...... set autoregression order (from 0 to 25) (default 8)
  threshold         <double>     ..F.A...... set threshold (from 1 to 100) (default 10)
  t                 <double>     ..F.A...... set threshold (from 1 to 100) (default 10)
  hsize             <int>        ..F.A...... set histogram size (from 100 to 9999) (default 1000)
  n                 <int>        ..F.A...... set histogram size (from 100 to 9999) (default 1000)
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
    ///  TS. adeclip           A->A       Remove clipping from input audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#adeclip
    /// </summary>
    public class AdeclipFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AdeclipFilter(AudioMap audioMap) : base("adeclip", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set window size, in milliseconds. Allowed range is from 10 to 100. Default value is 55 milliseconds. This sets size of window which will be processed at once.
        /// <br></br>(from 10 to 100) (default 55)
        /// </summary>
        /// <param name="window"></param>
        /// <returns></returns>
        public AdeclipFilter Window(double window)
          => this.SetOptionRange("w", window, 10, 100);
        /// <summary>
        /// Set window overlap, in percentage of window size. Allowed range is from 50 to 95. Default value is 75 percent.
        /// <br></br>(from 50 to 95) (default 75)
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AdeclipFilter Overlap(double overlap)
          => this.SetOptionRange("o", overlap, 50, 95);
        /// <summary>
        /// Set autoregression order, in percentage of window size. Allowed range is from 0 to 25. Default value is 8 percent. This option also controls quality of interpolated samples using neighbour good samples.<br>
        /// </br> (from 0 to 25) (default 2)
        /// </summary>
        /// <param name="arorder"></param>
        /// <returns></returns>
        public AdeclipFilter ArOrder(double arorder)
          => this.SetOptionRange("a", arorder, 0, 25);
        /// <summary>
        /// Set threshold value. Allowed range is from 1 to 100. Default value is 10. Higher values make clip detection less aggressive.<br>
        /// </br>(from 1 to 100) (default 10)
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AdeclipFilter Threshold(double threshold)
          => this.SetOptionRange("t", threshold, 1, 100);
        /// <summary>
        /// Set size of histogram used to detect clips. Allowed range is from 100 to 9999. Default value is 1000. Higher values make clip detection less aggressive.<br>
        /// </br> (from 100 to 9999) (default 1000)
        /// </summary>
        /// <param name="burst"></param>
        /// <returns></returns>
        public AdeclipFilter Hsize(int burst)
          => this.SetOptionRange("n", burst, 0, 10);
        /// <summary>
        /// Set overlap method.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public AdeclipFilter Method(AdeclipMethod method)
          => this.SetOption("m", method.ToString().ToLower());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AdeclipFilterExtensions
    {
        /// <summary>
        /// Remove clipped samples from input audio.<br>
        /// </br>Samples detected as clipped are replaced by interpolated samples using autoregressive modelling.
        /// </summary>
        public static AdeclipFilter AdeclipFilter(this AudioMap audioMap) => new AdeclipFilter(audioMap);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AdeclipMethod
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
