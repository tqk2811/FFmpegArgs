﻿using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... setpts            V->V       Set PTS for the output video frame.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts
    /// </summary>
    public class SetPtsFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "FRAME_RATE","FR",
            "PTS",
            "N",
            "NB_CONSUMED_SAMPLES",
            "NB_SAMPLES", "S",
            "SAMPLE_RATE", "SR",
            "STARTPTS",
            "STARTT",
            "INTERLACED",
            "T",
            "POS",
            "PREV_INPTS",
            "PREV_INT",
            "PREV_OUTPTS",
            "PREV_OUTT",
            "RTCTIME",
            "RTCSTART",
            "TB"
        };
        readonly Expression expression = new Expression(_variables);
        internal SetPtsFilter(Action<Expression> expr, ImageMap imageMap) : base("setpts", imageMap)
        {
            AddMapOut();
            this.SetOption("expr", expr.Run(expression));
        }
    }


    public static class SetPtsFilterExtension
    {
        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static SetPtsFilter SetPtsFilter(this ImageMap imageMap, Action<Expression> expr)
        {
            return new SetPtsFilter(expr, imageMap);
        }

        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static SetPtsFilter SetPtsFilter(this ImageMap imageMap, string expr)
        {
            return new SetPtsFilter(expr.Expression(), imageMap);
        }
    }
}
