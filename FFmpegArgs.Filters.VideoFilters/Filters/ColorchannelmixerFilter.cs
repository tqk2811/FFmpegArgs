namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC colorchannelmixer V->V       Adjust colors by mixing color channels.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colorchannelmixer
    /// </summary>
    public class ColorchannelmixerFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ColorchannelmixerFilter(ImageMap imageMap) : base("colorchannelmixer", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Allowed ranges for options are [-2.0, 2.0].
        /// </summary>
        /// <param name="contribution"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ColorchannelmixerFilter AdjustContribution(ColorchannelmixerContribution contribution, double val)
          => this.SetOptionRange(contribution.ToString(), val, -2.0, 2.0);
        /// <summary>
        /// Set preserve color mode.
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        public ColorchannelmixerFilter PreserveColorMode(ColorchannelmixerPreserveColorMode pc)
          => this.SetOption("pc", pc);
        /// <summary>
        /// Set the preserve color amount when changing colors. Allowed range is from [0.0, 1.0].<br>
        /// </br> Default is 0.0, thus disabled.
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public ColorchannelmixerFilter PreserveColorAmount(float pa)
          => this.SetOptionRange("pa", pa, 0.0f, 1.0f);
    }
    public static class ColorchannelmixerFilterExtensions
    {
        /// <summary>
        /// Adjust video input frames by re-mixing color channels.<br></br>
        /// This filter modifies a color channel by adding the values associated to the other channels of the same pixels.For example if the value to modify is red, the output value will be:<br></br>
        /// <b>red=red*rr + blue*rb + green*rg + alpha*ra</b><br></br>
        /// </summary>
        public static ColorchannelmixerFilter ColorchannelmixerFilter(this ImageMap imageMap)
          => new ColorchannelmixerFilter(imageMap);
    }
    public enum ColorchannelmixerContribution
    {
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output red channel. Default is 1 for rr, and 0 for rg, rb and ra.
        /// </summary>
        rr,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output red channel. Default is 1 for rr, and 0 for rg, rb and ra.
        /// </summary>
        rg,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output red channel. Default is 1 for rr, and 0 for rg, rb and ra.
        /// </summary>
        rb,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output red channel. Default is 1 for rr, and 0 for rg, rb and ra.
        /// </summary>
        ra,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output green channel. Default is 1 for gg, and 0 for gr, gb and ga.
        /// </summary>
        gr,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output green channel. Default is 1 for gg, and 0 for gr, gb and ga.
        /// </summary>
        gg,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output green channel. Default is 1 for gg, and 0 for gr, gb and ga.
        /// </summary>
        gb,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output green channel. Default is 1 for gg, and 0 for gr, gb and ga.
        /// </summary>
        ga,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output blue channel. Default is 1 for bb, and 0 for br, bg and ba.
        /// </summary>
        br,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output blue channel. Default is 1 for bb, and 0 for br, bg and ba.
        /// </summary>
        bg,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output blue channel. Default is 1 for bb, and 0 for br, bg and ba.
        /// </summary>
        bb,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output blue channel. Default is 1 for bb, and 0 for br, bg and ba.
        /// </summary>
        ba,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output alpha channel. Default is 1 for aa, and 0 for ar, ag and ab.
        /// </summary>
        ar,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output alpha channel. Default is 1 for aa, and 0 for ar, ag and ab.
        /// </summary>
        ag,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output alpha channel. Default is 1 for aa, and 0 for ar, ag and ab.
        /// </summary>
        ab,
        /// <summary>
        /// Adjust contribution of input red, green, blue and alpha channels for output alpha channel. Default is 1 for aa, and 0 for ar, ag and ab.
        /// </summary>
        aa
    }
    public enum ColorchannelmixerPreserveColorMode
    {
        /// <summary>
        /// Disable color preserving, this is default.
        /// </summary>
        none,
        /// <summary>
        /// Preserve luminance.
        /// </summary>
        lum,
        /// <summary>
        /// Preserve max value of RGB triplet.
        /// </summary>
        max,
        /// <summary>
        /// Preserve average value of RGB triplet.
        /// </summary>
        avg,
        /// <summary>
        /// Preserve sum value of RGB triplet.
        /// </summary>
        sum,
        /// <summary>
        /// Preserve normalized value of RGB triplet.
        /// </summary>
        nrm,
        /// <summary>
        /// Preserve power value of RGB triplet.
        /// </summary>
        pwr
    }
}
