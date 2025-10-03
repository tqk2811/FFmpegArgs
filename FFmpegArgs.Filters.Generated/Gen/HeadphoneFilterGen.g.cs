namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S. headphone         N-&gt;A       Apply headphone binaural spatialization with HRTFs in additional streams.
    /// </summary>
    public class HeadphoneFilterGen : AudioToAudioFilter, ISliceThreading
    {
        internal HeadphoneFilterGen(params AudioMap[] inputs) : base("headphone", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set channels convolution mappings
        /// </summary>
        public HeadphoneFilterGen map(String map) => this.SetOption("map", map.ToString());
        /// <summary>
        ///  set gain in dB (from -20 to 40) (default 0)
        /// </summary>
        public HeadphoneFilterGen gain(float gain) => this.SetOptionRange("gain", gain, -20, 40);
        /// <summary>
        ///  set lfe gain in dB (from -20 to 40) (default 0)
        /// </summary>
        public HeadphoneFilterGen lfe(float lfe) => this.SetOptionRange("lfe", lfe, -20, 40);
        /// <summary>
        ///  set processing (from 0 to 1) (default freq)
        /// </summary>
        public HeadphoneFilterGen type(HeadphoneFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set frame size (from 1024 to 96000) (default 1024)
        /// </summary>
        public HeadphoneFilterGen size(int size) => this.SetOptionRange("size", size, 1024, 96000);
        /// <summary>
        ///  set hrir format (from 0 to 1) (default stereo)
        /// </summary>
        public HeadphoneFilterGen hrir(HeadphoneFilterGenHrir hrir) => this.SetOption("hrir", hrir.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set processing (from 0 to 1) (default freq)
    /// </summary>
    public enum HeadphoneFilterGenType
    {
        /// <summary>
        /// time            0            ..F.A...... time domain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("time")]
        time = 0,
        /// <summary>
        /// freq            1            ..F.A...... frequency domain
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freq")]
        freq = 1
    }

    /// <summary>
    ///  set hrir format (from 0 to 1) (default stereo)
    /// </summary>
    public enum HeadphoneFilterGenHrir
    {
        /// <summary>
        /// stereo          0            ..F.A...... hrir files have exactly 2 channels
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stereo")]
        stereo = 0,
        /// <summary>
        /// multich         1            ..F.A...... single multichannel hrir file
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("multich")]
        multich = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply headphone binaural spatialization with HRTFs in additional streams.
        /// </summary>
        public static HeadphoneFilterGen HeadphoneFilterGen(this AudioMap input) => new HeadphoneFilterGen(input);
    }
}