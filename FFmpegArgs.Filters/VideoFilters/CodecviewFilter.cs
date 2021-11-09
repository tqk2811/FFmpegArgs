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
  /// <summary>
  /// T.. codecview         V->V       Visualize information about some codecs.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#codecview
  /// </summary>
  public class CodecviewFilter : ImageToImageFilter, ITimelineSupport
  {
    internal CodecviewFilter(ImageMap imageMap) : base("codecview", imageMap)
    {
      AddMapOut();
    }

#warning Need more info
    /// <summary>
    /// Display block partition structure using the luma plane.
    /// </summary>
    /// <param name="block"></param>
    /// <returns></returns>
    public CodecviewFilter Block(string block)
      => this.SetOption("block", block);

    /// <summary>
    /// Set motion vectors to visualize.
    /// </summary>
    /// <param name="motionVector"></param>
    /// <returns></returns>
    public CodecviewFilter MV(CodecviewMotionVector motionVector)
      => this.SetOption("mf", motionVector);

#warning Need more info
    /// <summary>
    /// Display quantization parameters using the chroma planes.
    /// </summary>
    /// <param name="qp"></param>
    /// <returns></returns>
    public CodecviewFilter QP(string qp)
      => this.SetOption("qp", qp);

    /// <summary>
    /// Set motion vectors type to visualize. Includes MVs from all frames unless specified by frame_type option.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public CodecviewFilter MvType(CodecviewMotionVectorType type)
      => this.SetOption("mvt", type);

    /// <summary>
    /// Set frame type to visualize motion vectors of.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public CodecviewFilter FrameType(CodecviewFrameType type)
      => this.SetOption("ft", type);
  }

  public static class CodecviewFilterExtensions
  {
    /// <summary>
    /// Visualize information exported by some codecs.<br></br>
    /// Some codecs can export information through frames using side-data or other means.For example, some MPEG based codecs export motion vectors through the export_mvs flag in the codec flags2 option.
    /// </summary>
    public static CodecviewFilter CodecviewFilter(this ImageMap imageMap)
      => new CodecviewFilter(imageMap);
  }

  public enum CodecviewMotionVector
  {
    /// <summary>
    /// forward predicted MVs of P-frames
    /// </summary>
    pf,
    /// <summary>
    /// forward predicted MVs of B-frames
    /// </summary>
    bf,
    /// <summary>
    /// backward predicted MVs of B-frames
    /// </summary>
    bb
  }

  public enum CodecviewMotionVectorType
  {
    /// <summary>
    /// forward predicted MVs
    /// </summary>
    fp,
    /// <summary>
    /// backward predicted MVs
    /// </summary>
    bp
  }

  public enum CodecviewFrameType
  {
    /// <summary>
    /// intra-coded frames (I-frames)
    /// </summary>
    _if,
    /// <summary>
    /// predicted frames (P-frames)
    /// </summary>
    _pf,
    /// <summary>
    /// bi-directionally predicted frames (B-frames)
    /// </summary>
    _bf,
  }
}
