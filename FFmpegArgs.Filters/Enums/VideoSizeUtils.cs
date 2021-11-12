﻿namespace FFmpegArgs.Filters.Enums
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-utils.html#video-size-syntax
    /// </summary>
    public enum VideoSizeUtils
    {
        /// <summary>
        /// 720x480
        /// </summary>
        [Name("ntsc")] ntsc,

        /// <summary>
        /// 720x576
        /// </summary>
        [Name("pal")] pal,

        /// <summary>
        /// 352x240
        /// </summary>
        [Name("qntsc")] qntsc,

        /// <summary>
        /// 352x288
        /// </summary>
        [Name("qpal")] qpal,

        /// <summary>
        /// 640x480
        /// </summary>
        [Name("sntsc")] sntsc,

        /// <summary>
        /// 768x576
        /// </summary>
        [Name("spal")] spal,

        /// <summary>
        /// 352x240
        /// </summary>
        [Name("film")] film,

        ///// <summary>
        ///// 352x240
        ///// </summary>
        [Name("ntsc-film")] NtscFilm,

        /// <summary>
        /// 128x96
        /// </summary>
        [Name("sqcif")] sqcif,

        /// <summary>
        /// 176x144
        /// </summary>
        [Name("qcif")] qcif,

        /// <summary>
        /// 352x288
        /// </summary>
        [Name("cif")] cif,

        ///// <summary>
        ///// 704x576
        ///// </summary>
        [Name("4cif")] _4cif,

        ///// <summary>
        ///// 1408x1152
        ///// </summary>
        [Name("16cif")] _16cif,

        /// <summary>
        /// 160x120
        /// </summary>
        [Name("qqvga")] qqvga,

        /// <summary>
        /// 320x240
        /// </summary>
        [Name("qvga")] qvga,

        /// <summary>
        /// 640x480
        /// </summary>
        [Name("vga")] vga,

        /// <summary>
        /// 800x600
        /// </summary>
        [Name("svga")] svga,

        /// <summary>
        /// 1024x768
        /// </summary>
        [Name("xga")] xga,

        /// <summary>
        /// 1600x1200
        /// </summary>
        [Name("uxga")] uxga,

        /// <summary>
        /// 2048x1536
        /// </summary>
        [Name("qxga")] qxga,

        /// <summary>
        /// 1280x1024
        /// </summary>
        [Name("sxga")] sxga,

        /// <summary>
        /// 2560x2048
        /// </summary>
        [Name("qsxga")] qsxga,

        /// <summary>
        /// 5120x4096
        /// </summary>
        [Name("hsxga")] hsxga,

        /// <summary>
        /// 852x480
        /// </summary>
        [Name("wvga")] wvga,

        /// <summary>
        /// 1366x768
        /// </summary>
        [Name("wxga")] wxga,

        /// <summary>
        /// 1600x1024
        /// </summary>
        [Name("wsxga")] wsxga,

        /// <summary>
        /// 1920x1200
        /// </summary>
        [Name("wuxga")] wuxga,

        /// <summary>
        /// 2560x1600
        /// </summary>
        [Name("woxga")] woxga,

        /// <summary>
        /// 3200x2048
        /// </summary>
        [Name("wqsxga")] wqsxga,

        /// <summary>
        /// 3840x2400
        /// </summary>
        [Name("wquxga")] wquxga,

        /// <summary>
        /// 6400x4096
        /// </summary>
        [Name("whsxga")] whsxga,

        /// <summary>
        /// 7680x4800
        /// </summary>
        [Name("whuxga")] whuxga,

        /// <summary>
        /// 320x200
        /// </summary>
        [Name("cga")] cga,

        /// <summary>
        /// 640x350
        /// </summary>
        [Name("ega")] ega,

        /// <summary>
        /// 852x480
        /// </summary>
        [Name("hd480")] hd480,

        /// <summary>
        /// 1280x720
        /// </summary>
        [Name("hd720")] hd720,

        /// <summary>
        /// 1920x1080
        /// </summary>
        [Name("hd1080")] hd1080,

        /// <summary>
        /// 2048x1080
        /// </summary>
        [Name("2k")] _2k,

        /// <summary>
        /// 1998x1080
        /// </summary>
        [Name("2kflat")] _2kflat,

        /// <summary>
        /// 2048x858
        /// </summary>
        [Name("2kscope")] _2kscope,

        /// <summary>
        /// 4096x2160
        /// </summary>
        [Name("4k")] _4k,

        /// <summary>
        /// 3996x2160
        /// </summary>
        [Name("4kflat")] _4kflat,

        /// <summary>
        /// 4096x1716
        /// </summary>
        [Name("4kscope")] _4kscope,

        /// <summary>
        /// 640x360
        /// </summary>
        [Name("nhd")] nhd,

        /// <summary>
        /// 240x160
        /// </summary>
        [Name("hqvga")] hqvga,

        /// <summary>
        /// 400x240
        /// </summary>
        [Name("wqvga")] wqvga,

        /// <summary>
        /// 432x240
        /// </summary>
        [Name("fwqvga")] fwqvga,

        /// <summary>
        /// 480x320
        /// </summary>
        [Name("hvga")] hvga,

        /// <summary>
        /// 960x540
        /// </summary>
        [Name("qhd")] qhd,

        /// <summary>
        /// 2048x1080
        /// </summary>
        [Name("2kdci")] _2kdci,

        /// <summary>
        /// 4096x2160
        /// </summary>
        [Name("4kdci")] _4kdci,

        /// <summary>
        /// 3840x2160
        /// </summary>
        [Name("uhd2160")] uhd2160,

        /// <summary>
        /// 7680x4320
        /// </summary>
        [Name("uhd4320")] uhd4320
    }
}
