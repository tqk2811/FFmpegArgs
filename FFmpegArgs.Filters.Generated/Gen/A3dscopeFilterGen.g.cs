namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ..C a3dscope          A-&gt;V       Convert input audio to 3d scope video output.
    /// </summary>
    public class A3dscopeFilterGen : AudioToImageFilter, ICommandSupport
    {
        internal A3dscopeFilterGen(AudioMap input) : base("a3dscope", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public A3dscopeFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video size (default &quot;hd720&quot;)
        /// </summary>
        public A3dscopeFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set camera FoV (from 40 to 150) (default 90)
        /// </summary>
        public A3dscopeFilterGen fov(float fov) => this.SetOptionRange("fov", fov, 40, 150);
        /// <summary>
        ///  set camera roll (from -180 to 180) (default 0)
        /// </summary>
        public A3dscopeFilterGen roll(float roll) => this.SetOptionRange("roll", roll, -180, 180);
        /// <summary>
        ///  set camera pitch (from -180 to 180) (default 0)
        /// </summary>
        public A3dscopeFilterGen pitch(float pitch) => this.SetOptionRange("pitch", pitch, -180, 180);
        /// <summary>
        ///  set camera yaw (from -180 to 180) (default 0)
        /// </summary>
        public A3dscopeFilterGen yaw(float yaw) => this.SetOptionRange("yaw", yaw, -180, 180);
        /// <summary>
        ///  set camera zoom (from 0.01 to 10) (default 1)
        /// </summary>
        public A3dscopeFilterGen xzoom(float xzoom) => this.SetOptionRange("xzoom", xzoom, 0.01, 10);
        /// <summary>
        ///  set camera zoom (from 0.01 to 10) (default 1)
        /// </summary>
        public A3dscopeFilterGen yzoom(float yzoom) => this.SetOptionRange("yzoom", yzoom, 0.01, 10);
        /// <summary>
        ///  set camera zoom (from 0.01 to 10) (default 1)
        /// </summary>
        public A3dscopeFilterGen zzoom(float zzoom) => this.SetOptionRange("zzoom", zzoom, 0.01, 10);
        /// <summary>
        ///  set camera position (from -60 to 60) (default 0)
        /// </summary>
        public A3dscopeFilterGen xpos(float xpos) => this.SetOptionRange("xpos", xpos, -60, 60);
        /// <summary>
        ///  set camera position (from -60 to 60) (default 0)
        /// </summary>
        public A3dscopeFilterGen ypos(float ypos) => this.SetOptionRange("ypos", ypos, -60, 60);
        /// <summary>
        ///  set camera position (from -60 to 60) (default 0)
        /// </summary>
        public A3dscopeFilterGen zpos(float zpos) => this.SetOptionRange("zpos", zpos, -60, 60);
        /// <summary>
        ///  set length (from 1 to 60) (default 15)
        /// </summary>
        public A3dscopeFilterGen length(int length) => this.SetOptionRange("length", length, 1, 60);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to 3d scope video output.
        /// </summary>
        public static A3dscopeFilterGen A3dscopeFilterGen(this AudioMap input0) => new A3dscopeFilterGen(input0);
    }
}