using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.VideoFilters
{
    ///// <summary>
    ///// <br></br>
    ///// https://ffmpeg.org/ffmpeg-filters.html#coreimage-1
    ///// </summary>
    //public class CoreimageFilter : ImageToImageFilter
    //{
    //    internal CoreimageFilter(ImageMap imageMap) : base("coreimage", imageMap)
    //    {
    //        AddMapOut();
    //    }
    //}

    //public static class CoreimageFilterExtensions
    //{
    //    /// <summary>
    //    /// Video filtering on GPU using Apple’s CoreImage API on OSX.<br></br>
    //    /// Hardware acceleration is based on an OpenGL context.Usually, this means it is processed by video hardware.However, software-based OpenGL implementations exist which means there is no guarantee for hardware processing. It depends on the respective OSX.<br></br>
    //    /// There are many filters and image generators provided by Apple that come with a large variety of options. The filter has to be referenced by its name along with its options.
    //    /// </summary>
    //    public static CoreimageFilter CoreimageFilter(this ImageMap imageMap)
    //      => new CoreimageFilter(imageMap);
    //}
}
