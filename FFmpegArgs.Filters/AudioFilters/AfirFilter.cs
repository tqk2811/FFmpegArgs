using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// .SC afir              N->N       Apply Finite Impulse Response filter with supplied coefficients in additional stream(s)<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#afir-1
  /// </summary>
  public class AfirFilter : AudioToAudioFilter, ISliceThreading, ICommandSupport
  {
    internal AfirFilter(AudioMap audioMap) : base("afir", audioMap)
    {
      AddMapOut();
    }

#warning Need more info
    //dry
    //  Set dry gain.This sets input gain.

    //wet
    //  Set wet gain. This sets final output gain.

    //length
    //  Set Impulse Response filter length. Default is 1, which means whole IR is processed.

    /// <summary>
    /// Enable applying gain measured from power of IR.<br></br>
    /// Set which approach to use for auto gain measurement.
    /// </summary>
    /// <param name="gtype"></param>
    /// <returns></returns>
    public AfirFilter Gtype(AfirGtype gtype)
      => this.SetOption("gtype", gtype);

    /// <summary>
    /// Set gain to be applied to IR coefficients before filtering. <br>
    /// </br>Allowed range is 0 to 1. This gain is applied after any gain applied with gtype option.
    /// </summary>
    /// <param name="irgain"></param>
    /// <returns></returns>
    public AfirFilter IrGain(float irgain)
      => this.SetOptionRange("irgain", irgain, 0, 1);

    /// <summary>
    /// Set format of IR stream. Can be mono or input. Default is input.
    /// </summary>
    /// <param name="irfmt"></param>
    /// <returns></returns>
    public AfirFilter Irfmt(AfirIrfmt irfmt)
      => this.SetOption("irfmt", irfmt);

    /// <summary>
    /// Set max allowed Impulse Response filter duration in seconds. Default is 30 seconds. Allowed range is 0.1 to 60 seconds.
    /// </summary>
    /// <param name="maxir"></param>
    /// <returns></returns>
    public AfirFilter MaxIr(float maxir)
      => this.SetOptionRange("maxir", maxir, 0.1, 60);

    /// <summary>
    /// Show IR frequency response, magnitude(magenta), phase(green) and group delay(yellow) in additional video stream. By default it is disabled.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public AfirFilter Response(bool flag)
      => this.SetOption("response", flag.ToFFmpegFlag());

    /// <summary>
    /// Set for which IR channel to display frequency response. By default is first channel displayed. This option is used only when response is enabled.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public AfirFilter Channel(double channel)
      => this.SetOption("channel", channel);

    /// <summary>
    /// Set video stream size. This option is used only when response is enabled.
    /// </summary>
    /// <param name="size"></param>
    /// <returns></returns>
    public AfirFilter Size(double size)
      => this.SetOption("size", size);

    /// <summary>
    /// Set video stream frame rate. This option is used only when response is enabled.
    /// </summary>
    /// <param name="rate"></param>
    /// <returns></returns>
    public AfirFilter Rate(int rate)
      => this.SetOptionRange("rate", rate, 1, int.MaxValue);

    /// <summary>
    /// Set minimal partition size used for convolution. Default is 8192. Allowed range is from 1 to 32768.<br>
    /// </br> Lower values decreases latency at cost of higher CPU usage.
    /// </summary>
    /// <param name="minp"></param>
    /// <returns></returns>
    public AfirFilter Minp(int minp)
      => this.SetOptionRange("minp", minp, 1, 32768);

    /// <summary>
    /// Set maximal partition size used for convolution. Default is 8192. Allowed range is from 8 to 32768.<br>
    /// </br> Lower values may increase CPU usage.
    /// </summary>
    /// <param name="maxp"></param>
    /// <returns></returns>
    public AfirFilter Maxp(int maxp)
     => this.SetOptionRange("maxp", maxp, 8, 32768);

    /// <summary>
    /// Set number of input impulse responses streams which will be switchable at runtime.<br>
    /// </br> Allowed range is from 1 to 32. Default is 1.
    /// </summary>
    /// <param name="nbirs"></param>
    /// <returns></returns>
    public AfirFilter Nbirs(int nbirs)
     => this.SetOptionRange("nbirs", nbirs, 1, 32);

    /// <summary>
    /// Set IR stream which will be used for convolution, starting from 0, should always be lower than supplied value by nbirs option.<br>
    /// </br> Default is 0. This option can be changed at runtime via commands.
    /// </summary>
    /// <param name="ir"></param>
    /// <returns></returns>
    public AfirFilter Ir(int ir)
     => this.SetOptionRange("ir", ir, 0, int.MaxValue);
  }

  public static class AfirFilterExtension
  {
    /// <summary>
    /// Apply an arbitrary Finite Impulse Response filter.
    /// This filter is designed for applying long FIR filters, up to 60 seconds long.
    /// It can be used as component for digital crossover filters, room equalization, cross talk cancellation, wavefield synthesis, auralization, ambiophonics, ambisonics and spatialization.
    /// This filter uses the streams higher than first one as FIR coefficients.If the non-first stream holds a single channel, it will be used for all input channels in the first stream, otherwise the number of channels in the non-first stream must be same as the number of channels in the first stream.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AfirFilter AfirFilter(this AudioMap audioMap)
      => new AfirFilter(audioMap);
  }

  public enum AfirGtype
  {
    /// <summary>
    /// Do not apply any gain.
    /// </summary>
    none,
    /// <summary>
    /// select peak gain, very conservative approach. This is default value.
    /// </summary>
    peak,
    /// <summary>
    /// select DC gain, limited application.
    /// </summary>
    dc,
    /// <summary>
    /// select gain to noise approach, this is most popular one.
    /// </summary>
    gn
  }

  public enum AfirIrfmt
  {
    mono,
    input
  }

}
