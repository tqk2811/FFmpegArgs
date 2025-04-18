namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC chromanr          V->V       Reduce chrominance noise.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#chromanr
    /// </summary>
    public class ChromanrFilter : ImageToImageFilter
    {
        internal ChromanrFilter(ImageMap imageMap) : base("chromanr", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set threshold for averaging chrominance values.<br>
        /// </br> Sum of absolute difference of Y, U and V pixel components of current pixel and neighbour pixels lower than this threshold will be used in averaging.<br>
        /// </br> Luma component is left unchanged and is copied to output. Default value is 30. Allowed range is from 1 to 200.
        /// </summary>
        /// <param name="thres"></param>
        /// <returns></returns>
        public ChromanrFilter Thres(float thres)
          => this.SetOptionRange("thres", thres, 1, 200);
        /// <summary>
        /// Set horizontal radius of rectangle used for averaging. Allowed range is from 1 to 100. Default value is 5.
        /// </summary>
        /// <param name="sizew"></param>
        /// <returns></returns>
        public ChromanrFilter SizeW(int sizew)
          => this.SetOptionRange("sizew", sizew, 1, 100);
        /// <summary>
        /// Set vertical radius of rectangle used for averaging. Allowed range is from 1 to 100. Default value is 5.
        /// </summary>
        /// <param name="sizeh"></param>
        /// <returns></returns>
        public ChromanrFilter SizeH(int sizeh)
          => this.SetOptionRange("sizeh", sizeh, 1, 100);
        /// <summary>
        /// Set horizontal step when averaging. Default value is 1. Allowed range is from 1 to 50. Mostly useful to speed-up filtering.
        /// </summary>
        /// <param name="stepw"></param>
        /// <returns></returns>
        public ChromanrFilter StepW(int stepw)
          => this.SetOptionRange("stepw", stepw, 1, 50);
        /// <summary>
        /// Set vertical step when averaging. Default value is 1. Allowed range is from 1 to 50. Mostly useful to speed-up filtering.
        /// </summary>
        /// <param name="steph"></param>
        /// <returns></returns>
        public ChromanrFilter StepH(int steph)
          => this.SetOptionRange("steph", steph, 1, 50);
        /// <summary>
        /// Set Y threshold for averaging chrominance values.<br>
        /// </br> Set finer control for max allowed difference between Y components of current pixel and neigbour pixels.<br>
        /// </br> Default value is 200. Allowed range is from 1 to 200.
        /// </summary>
        /// <param name="threy"></param>
        /// <returns></returns>
        public ChromanrFilter ThreY(float threy)
          => this.SetOptionRange("threy", threy, 1, 200);
        /// <summary>
        /// Set U threshold for averaging chrominance values.<br>
        /// </br> Set finer control for max allowed difference between U components of current pixel and neigbour pixels.<br>
        /// </br> Default value is 200. Allowed range is from 1 to 200.
        /// </summary>
        /// <param name="threu"></param>
        /// <returns></returns>
        public ChromanrFilter ThreU(float threu)
          => this.SetOptionRange("threu", threu, 1, 200);
        /// <summary>
        /// Set V threshold for averaging chrominance values.<br>
        /// </br> Set finer control for max allowed difference between V components of current pixel and neigbour pixels.<br>
        /// </br> Default value is 200. Allowed range is from 1 to 200.
        /// </summary>
        /// <param name="threv"></param>
        /// <returns></returns>
        public ChromanrFilter ThreV(float threv)
          => this.SetOptionRange("threv", threv, 1, 200);
        /// <summary>
        /// Set distance type used in calculations.<br></br>
        /// Default distance type is manhattan.
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        public ChromanrFilter Distance(ChromanrDistance distance)
          => this.SetOption("distance", distance);
    }
    public static class ChromanrFilterExtensions
    {
        /// <summary>
        /// Reduce chrominance noise.
        /// </summary>
        public static ChromanrFilter chromanrFilter(this ImageMap imageMap)
          => new ChromanrFilter(imageMap);
    }
    public enum ChromanrDistance
    {
        /// <summary>
        /// Absolute difference.
        /// </summary>
        manhattan,
        /// <summary>
        /// Difference squared.
        /// </summary>
        euclidean
    }
}
