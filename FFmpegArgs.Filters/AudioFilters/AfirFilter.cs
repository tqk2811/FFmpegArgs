/*
afir AVOptions:
  dry               <float>      ..F.A...... set dry gain (from 0 to 10) (default 1)
  wet               <float>      ..F.A...... set wet gain (from 0 to 10) (default 1)
  length            <float>      ..F.A...... set IR length (from 0 to 1) (default 1)
  gtype             <int>        ..F.A...... set IR auto gain type (from -1 to 2) (default peak)
     none            -1           ..F.A...... without auto gain
     peak            0            ..F.A...... peak gain
     dc              1            ..F.A...... DC gain
     gn              2            ..F.A...... gain to noise
  irgain            <float>      ..F.A...... set IR gain (from 0 to 1) (default 1)
  irfmt             <int>        ..F.A...... set IR format (from 0 to 1) (default input)
     mono            0            ..F.A...... single channel
     input           1            ..F.A...... same as input
  maxir             <float>      ..F.A...... set max IR length (from 0.1 to 60) (default 30)
  response          <boolean>    ..FV....... show IR frequency response (default false)
  channel           <int>        ..FV....... set IR channel to display frequency response (from 0 to 1024) (default 0)
  size              <image_size> ..FV....... set video size (default "hd720")
  rate              <video_rate> ..FV....... set video rate (default "25")
  minp              <int>        ..F.A...... set min partition size (from 1 to 32768) (default 8192)
  maxp              <int>        ..F.A...... set max partition size (from 8 to 32768) (default 8192)
  nbirs             <int>        ..F.A...... set number of input IRs (from 1 to 32) (default 1)
  ir                <int>        ..F.A....T. select IR (from 0 to 31) (default 0)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// .SC afir              N->N       Apply Finite Impulse Response filter with supplied coefficients in additional stream(s)<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#afir-1"/>
    /// </summary>
    public class AfirFilter : AudioToAudioFilter, ISliceThreading, ICommandSupport
    {
        internal AfirFilter(AudioMap audioMap) : base("afir", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set dry gain. This sets input gain. (from 0 to 10) (default 1)
        /// </summary>
        /// <param name="dry"></param>
        /// <returns></returns>
        public AfirFilter Dry(float dry)
            => this.SetOptionRange("dry", dry, 0, 10);
        /// <summary>
        /// Set wet gain. This sets final output gain. (from 0 to 10) (default 1)
        /// </summary>
        /// <param name="wet"></param>
        /// <returns></returns>
        public AfirFilter Wet(float wet)
            => this.SetOptionRange("wet", wet, 0, 10);
        /// <summary>
        /// Set Impulse Response filter length. Default is 1, which means whole IR is processed. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public AfirFilter Length(float length)
            => this.SetOptionRange("length", length, 0, 1);
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
        /// </br>Allowed range is 0 to 1. This gain is applied after any gain applied with gtype option. (from 0 to 1) (default 1)
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
        /// <br></br>(from 0 to 1024) (default 0)
        /// </summary>
        /// <param name="channel"></param>
        /// <returns></returns>
        public AfirFilter Channel(int channel)
          => this.SetOptionRange("channel", channel, 0, 1024);
        /// <summary>
        /// Set video stream size. This option is used only when response is enabled.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AfirFilter Size(Size size)
          => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        /// Set video stream frame rate. This option is used only when response is enabled.
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        public AfirFilter Rate(Rational rate)
          => this.SetOption("rate", rate.Check(0, double.MaxValue));
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
        /// <br></br>select IR (from 0 to 31) (default 0)
        /// </summary>
        /// <param name="ir"></param>
        /// <returns></returns>
        public AfirFilter Ir(int ir)
         => this.SetOptionRange("ir", ir, 0, 31);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AfirFilterExtension
    {
        /// <summary>
        /// Apply an arbitrary Finite Impulse Response filter.
        /// This filter is designed for applying long FIR filters, up to 60 seconds long.
        /// It can be used as component for digital crossover filters, room equalization, cross talk cancellation, wavefield synthesis, auralization, ambiophonics, ambisonics and spatialization.
        /// This filter uses the streams higher than first one as FIR coefficients.If the non-first stream holds a single channel, it will be used for all input channels in the first stream, otherwise the number of channels in the non-first stream must be same as the number of channels in the first stream.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#afir-1"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AfirFilter AfirFilter(this AudioMap audioMap)
          => new AfirFilter(audioMap);
    }
    /// <summary>
    /// 
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public enum AfirIrfmt
    {
        /// <summary>
        /// single channel
        /// </summary>
        mono,
        /// <summary>
        /// same as input
        /// </summary>
        input
    }
}
