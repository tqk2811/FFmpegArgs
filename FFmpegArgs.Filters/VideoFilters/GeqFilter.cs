using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoFilters
{
    public class GeqFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variable = new List<string>()
        {
            "N", "X", "Y", "W", "H",
            "SW", "SH", "T"
        };
        static readonly IEnumerable<ShuntingYardFunction> _funcs = new List<ShuntingYardFunction>()
        {
            new ShuntingYardFunction("p","p_2"),
            new ShuntingYardFunction("lum","lum_2"),
            new ShuntingYardFunction("cb","cb_2"),
            new ShuntingYardFunction("cr","cr_2"),
            new ShuntingYardFunction("r","r_2"),
            new ShuntingYardFunction("g","g_2"),
            new ShuntingYardFunction("b","b_2"),
            new ShuntingYardFunction("alpha","alpha_2"),

            new ShuntingYardFunction("psum","psum_2"),
            new ShuntingYardFunction("lumsum","lumsum_2"),
            new ShuntingYardFunction("cbsum","cbsum_2"),
            new ShuntingYardFunction("crsum","crsum_2"),
            new ShuntingYardFunction("rsum","rsum_2"),
            new ShuntingYardFunction("gsum","gsum_2"),
            new ShuntingYardFunction("bsum","bsum_2"),
            new ShuntingYardFunction("alphasum","alphasum_2"),
        };
        readonly FFmpegExpression fFmpegExpression = new FFmpegExpression(_variable, _funcs);
        internal GeqFilter(ImageMap imageMap) : base("geq", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the luminance expression.
        /// </summary>
        /// <param name="lum"></param>
        /// <returns></returns>
        public GeqFilter Lum(string lum)
            => this.SetOption("lum", lum.Expression().Run(fFmpegExpression));

        /// <summary>
        /// Set the chrominance blue expression.
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public GeqFilter Cb(string cb)
            => this.SetOption("cb", cb.Expression().Run(fFmpegExpression));

        /// <summary>
        /// Set the chrominance red expression.
        /// </summary>
        /// <param name="cr"></param>
        /// <returns></returns>
        public GeqFilter Cr(string cr)
            => this.SetOption("cr", cr.Expression().Run(fFmpegExpression));

        /// <summary>
        /// Set the alpha expression.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public GeqFilter A(string a)
            => this.SetOption("a", a.Expression().Run(fFmpegExpression));

        /// <summary>
        /// Set the red expression.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public GeqFilter R(string r)
            => this.SetOption("r", r.Expression().Run(fFmpegExpression));

        /// <summary>
        /// Set the green expression.
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public GeqFilter G(string g)
            => this.SetOption("g", g.Expression().Run(fFmpegExpression));

        /// <summary>
        /// Set the blue expression.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public GeqFilter B(string b)
            => this.SetOption("b", b.Expression().Run(fFmpegExpression));
    }

    public static class GeqFilterExtensions
    {
        /// <summary>
        /// Apply generic equation to each pixel.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static GeqFilter GeqFilter(this ImageMap imageMap)
            => new GeqFilter(imageMap);
    }
}
