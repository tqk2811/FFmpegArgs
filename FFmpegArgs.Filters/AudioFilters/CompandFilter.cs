/*
compand AVOptions:
  attacks           <string>     ..F.A...... set time over which increase of volume is determined (default "0")
  decays            <string>     ..F.A...... set time over which decrease of volume is determined (default "0.8")
  points            <string>     ..F.A...... set points of transfer function (default "-70/-70|-60/-20|1/0")
  soft-knee         <double>     ..F.A...... set soft-knee (from 0.01 to 900) (default 0.01)
  gain              <double>     ..F.A...... set output gain (from -900 to 900) (default 0)
  volume            <double>     ..F.A...... set initial volume (from -900 to 0) (default 0)
  delay             <double>     ..F.A...... set delay for samples before sending them to volume adjuster (from 0 to 20) (default 0)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... compand           A->A       Compress or expand audio dynamic range.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#compand"/>
    /// </summary>
    public class CompandFilter : AudioToAudioFilter
    {
        internal CompandFilter(AudioMap audioMap) : base("compand", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// A list of times in seconds for each channel over which the instantaneous level of the input signal is averaged to determine its volume. attacks refers to increase of volume and decays refers to decrease of volume. For most situations, the attack time (response to the audio getting louder) should be shorter than the decay time, because the human ear is more sensitive to sudden loud audio than sudden soft audio. A typical value for attack is 0.3 seconds and a typical value for decay is 0.8 seconds. If specified number of attacks & decays is lower than number of channels, the last set attack/decay will be used for all remaining channels.
        /// </summary>
        /// <param name="attacks"></param>
        /// <returns></returns>
        public CompandFilter Attacks(string attacks)
            => this.SetOption("attacks", attacks);
        /// <summary>
        /// A list of times in seconds for each channel over which the instantaneous level of the input signal is averaged to determine its volume. attacks refers to increase of volume and decays refers to decrease of volume. For most situations, the attack time (response to the audio getting louder) should be shorter than the decay time, because the human ear is more sensitive to sudden loud audio than sudden soft audio. A typical value for attack is 0.3 seconds and a typical value for decay is 0.8 seconds. If specified number of attacks & decays is lower than number of channels, the last set attack/decay will be used for all remaining channels.
        /// </summary>
        /// <param name="decays"></param>
        /// <returns></returns>
        public CompandFilter Decays(string decays)
            => this.SetOption("decays", decays);

        /// <summary>
        /// A list of points for the transfer function, specified in dB relative to the maximum possible signal amplitude. Each key points list must be defined using the following syntax: x0/y0|x1/y1|x2/y2|.... or x0/y0 x1/y1 x2/y2 ....<br>
        /// </br>The input values must be in strictly increasing order but the transfer function does not have to be monotonically rising.The point 0/0 is assumed but may be overridden (by 0/out-dBn). Typical values for the transfer function are -70/-70|-60/-20|1/0.
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public CompandFilter Points(string points)
            => this.SetOption("points", points);

        /// <summary>
        /// Set the curve radius in dB for all joints.<br>
        /// </br>(from 0.01 to 900) (default 0.01)
        /// </summary>
        /// <param name="softKnee"></param>
        /// <returns></returns>
        public CompandFilter SoftKnee(double softKnee)
            => this.SetOptionRange("soft-knee", softKnee, 0.01, 900);

        /// <summary>
        /// Set the additional gain in dB to be applied at all points on the transfer function. This allows for easy adjustment of the overall gain.<br>
        /// </br>(from -900 to 900) (default 0)
        /// </summary>
        /// <param name="gain"></param>
        /// <returns></returns>
        public CompandFilter Gain(double gain)
            => this.SetOptionRange("gain", gain, -900, 900);

        /// <summary>
        /// Set an initial volume, in dB, to be assumed for each channel when filtering starts. This permits the user to supply a nominal level initially, so that, for example, a very large gain is not applied to initial signal levels before the companding has begun to operate. A typical value for audio which is initially quiet is -90 dB. It defaults to 0.<br>
        /// </br>(from -900 to 0) (default 0)
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public CompandFilter Volume(double volume)
            => this.SetOptionRange("volume", volume, -900, 0);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class CompandFilterExtensions
    {
        /// <summary>
        /// Compress or expand the audio’s dynamic range.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#compand"/>
        /// </summary>
        public static CompandFilter CompandFilter(this AudioMap audioMap)
          => new CompandFilter(audioMap);
    }
}
