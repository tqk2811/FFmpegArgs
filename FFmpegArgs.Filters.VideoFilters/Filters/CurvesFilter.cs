namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC curves            V->V       Adjust components curves.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#curves-1
    /// </summary>
    public class CurvesFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal CurvesFilter(ImageMap imageMap) : base("curves", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Select one of the available color presets. This option can be used in addition to the r, g, b parameters; in this case, the later options takes priority on the preset values.
        /// </summary>
        /// <param name="preset"></param>
        /// <returns></returns>
        public CurvesFilter Preset(CurvesPreset preset)
            => this.SetOption("preset", preset);
        /// <summary>
        /// Set the master key points. These points will define a second pass mapping. It is sometimes called a "luminance" or "value" mapping. It can be used with r, g, b or all since it acts like a post-processing LUT.<br></br>
        /// To avoid some filtergraph syntax conflicts, each key points list need to be defined using the following syntax: x0/y0 x1/y1 x2/y2 ....
        /// </summary>
        /// <param name="master"></param>
        /// <returns></returns>
        public CurvesFilter Master(string master)
            => this.SetOption("m", master);
        /// <summary>
        /// Set the key points for the red component.<br></br>
        /// To avoid some filtergraph syntax conflicts, each key points list need to be defined using the following syntax: x0/y0 x1/y1 x2/y2 ....
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public CurvesFilter Red(string r)
            => this.SetOption("r", r);
        /// <summary>
        /// Set the key points for the green component.<br></br>
        /// To avoid some filtergraph syntax conflicts, each key points list need to be defined using the following syntax: x0/y0 x1/y1 x2/y2 ....
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public CurvesFilter Green(string g)
            => this.SetOption("g", g);
        /// <summary>
        /// Set the key points for the blue component.<br></br>
        /// To avoid some filtergraph syntax conflicts, each key points list need to be defined using the following syntax: x0/y0 x1/y1 x2/y2 ....
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public CurvesFilter Blue(string b)
            => this.SetOption("b", b);
        /// <summary>
        /// Set the key points for all components (not including master). Can be used in addition to the other key points component options. In this case, the unset component(s) will fallback on this all setting.<br></br>
        /// To avoid some filtergraph syntax conflicts, each key points list need to be defined using the following syntax: x0/y0 x1/y1 x2/y2 ....
        /// </summary>
        /// <param name="all"></param>
        /// <returns></returns>
        public CurvesFilter All(string all)
            => this.SetOption("all", all);
        /// <summary>
        /// Specify a Photoshop curves file (.acv) to import the settings from.
        /// </summary>
        /// <param name="psfile"></param>
        /// <returns></returns>
        public CurvesFilter PsFile(string psfile)
            => this.SetOption("psfile", psfile);
        /// <summary>
        /// Save Gnuplot script of the curves in specified file.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public CurvesFilter Plot(string file)
            => this.SetOption("plot", file);
    }
    public static class CurvesFilterExtensions
    {
        /// <summary>
        /// Apply color adjustments using curves.<br>
        /// </br>This filter is similar to the Adobe Photoshop and GIMP curves tools.Each component(red, green and blue) has its values defined by N key points tied from each other using a smooth curve.The x-axis represents the pixel values from the input frame, and the y-axis the new pixel values to be set for the output frame.<br>
        /// </br>By default, a component curve is defined by the two points(0;0) and(1;1). This creates a straight line where each original pixel value is "adjusted" to its own value, which means no change to the image.<br>
        /// </br>The filter allows you to redefine these two points and add some more. A new curve(using a natural cubic spline interpolation) will be define to pass smoothly through all these new coordinates.The new defined points needs to be strictly increasing over the x-axis, and their x and y values must be in the[0;1] interval.If the computed curves happened to go outside the vector spaces, the values will be clipped accordingly.
        /// </summary>
        public static CurvesFilter CurvesFilter(this ImageMap imageMap)
          => new CurvesFilter(imageMap);
    }
    public enum CurvesPreset
    {
        none,
        color_negative,
        cross_process,
        darker,
        increase_contrast,
        lighter,
        linear_contrast,
        medium_contrast,
        negative,
        strong_contrast,
        vintage
    }
}
