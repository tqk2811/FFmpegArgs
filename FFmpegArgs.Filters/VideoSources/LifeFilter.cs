using FFmpegArgs.Expressions;
using FFmpegArgs.Filters.Enums;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... life              |->V       Create life.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#life
    /// </summary>
    public class LifeFilter : SourceImageFilter
    {
        readonly Expression expression = new Expression();
        internal LifeFilter(FilterGraph filterGraph) : base("life", filterGraph)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the file from which to read the initial grid state. In the file, each non-whitespace character is considered an alive cell, and newline is used to delimit the end of each row.<br></br>
        /// If this option is not specified, the initial grid is generated randomly.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public LifeFilter FileName(string f)
          => this.SetOption("f", f);

        /// <summary>
        /// Set frame rate, expressed as number of frames per second. Default value is "25".
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public LifeFilter Rate(int r)
          => this.SetOptionRange("r", r, 0, int.MaxValue);

        /// <summary>
        /// Set the random fill ratio for the initial random grid. It is a floating point number value ranging from 0 to 1, defaults to 1/PHI.<br>
        /// </br> It is ignored when a file is specified.
        /// </summary>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public LifeFilter RandomFillRatio(double ratio)
          => this.SetOptionRange("ratio", ratio, 0, 1);

        /// <summary>
        /// Set the seed for filling the initial random grid, must be an integer included between 0 and UINT32_MAX.<br>
        /// </br> If not specified, or if explicitly set to -1, the filter will try to use a good random seed on a best effort basis.
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public LifeFilter RandomSeed(long seed)
          => this.SetOptionRange("seed", seed, 0, uint.MaxValue);

        /// <summary>
        /// Set the life rule.<br></br>
        /// A rule can be specified with a code of the kind "SNS/BNB", where NS and NB are sequences of numbers in the range 0-8, NS specifies the number of alive neighbor cells which make a live cell stay alive, and NB the number of alive neighbor cells which make a dead cell to become alive(i.e.to "born"). "s" and "b" can be used in place of "S" and "B", respectively.<br></br>
        /// Alternatively a rule can be specified by an 18-bits integer.The 9 high order bits are used to encode the next cell state if it is alive for each number of neighbor alive cells, the low order bits specify the rule for "borning" new cells.Higher order bits encode for an higher number of neighbor cells.For example the number 6153 = (12<<9)+9 specifies a stay alive rule of 12 and a born rule of 9, which corresponds to "S23/B03".<br></br>
        /// Default value is "S23/B3", which is the original Conway’s game of life rule, and will keep a cell alive if it has 2 or 3 neighbor alive cells, and will born a new cell if there are three alive cells around a dead cell.
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public LifeFilter Rule(string rule)
          => this.SetOption("rule", rule);

        /// <summary>
        /// Set the size of the output video<br></br>
        /// If filename is specified, the size is set by default to the same size of the input file.If size is set, it must contain the size specified in the input file, and the initial grid defined in that file is centered in the larger resulting area.<br></br>
        /// If a filename is not specified, the size value defaults to "320x240" (used for a randomly generated initial grid).
        /// </summary>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public LifeFilter Size(VideoSizeUtils videoSize)
          => this.SetOption("size", videoSize.GetAttribute<NameAttribute>().Name);

        /// <summary>
        /// Set the size of the output video<br></br>
        /// If filename is specified, the size is set by default to the same size of the input file.If size is set, it must contain the size specified in the input file, and the initial grid defined in that file is centered in the larger resulting area.<br></br>
        /// If a filename is not specified, the size value defaults to "320x240" (used for a randomly generated initial grid).
        /// </summary>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public LifeFilter Size(Size videoSize)
          => this.SetOption("size", $"{videoSize.Width}x{videoSize.Height}");

        /// <summary>
        /// If set to 1, stitch the left and right grid edges together, and the top and bottom edges also. Defaults to 1.
        /// </summary>
        /// <param name="stitch"></param>
        /// <returns></returns>
        public LifeFilter Stitch(bool stitch)
          => this.SetOption("stitch", stitch.ToFFmpegFlag());

        /// <summary>
        /// Set cell mold speed.<br></br>
        /// If set, a dead cell will go from death_color to mold_color with a step of mold. mold can have a value from 0 to 255.
        /// </summary>
        /// <param name="mold"></param>
        /// <returns></returns>
        public LifeFilter Mold(int mold)
          => this.SetOptionRange("mold", mold, 0, 255);

        /// <summary>
        /// Set the color of living (or new born) cells.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public LifeFilter LifeColor(Color c)
          => this.SetOption("life_color", c.ToHexStringRGBA());

        /// <summary>
        /// Set the color of dead cells. If mold is set, this is the first color used to represent a dead cell.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public LifeFilter DeathColor(Color c)
          => this.SetOption("death_color", c.ToHexStringRGBA());

        /// <summary>
        /// Set mold color, for definitely dead and moldy cells.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public LifeFilter MoldColor(Color c)
          => this.SetOption("mold_color", c.ToHexStringRGBA());
    }

    public static class LifeFilterExtensions
    {
        /// <summary>
        /// Generate a life pattern.<br></br>
        /// This source is based on a generalization of John Conway’s life game.<br></br>
        /// The sourced input represents a life grid, each pixel represents a cell which can be in one of two possible states, alive or dead.Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.<br></br>
        /// At each interaction the grid evolves according to the adopted rule, which specifies the number of neighbor alive cells which will make a cell stay alive or born.The rule option allows one to specify the rule to adopt.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static LifeFilter LifeFilter(this FilterGraph filterGraph)
          => new LifeFilter(filterGraph);
    }
}
