namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ..C avsynctest        |-&gt;AV      Generate an Audio Video Sync Test.
/// </summary>
public class AvsynctestFilterGen : SourceToAudioFilter,ICommandSupport
{
internal AvsynctestFilterGen(IAudioFilterGraph input) : base("avsynctest",input) { AddMapOut(); }
/// <summary>
///  set frame size (default &quot;hd720&quot;)
/// </summary>
public AvsynctestFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set frame rate (default &quot;30&quot;)
/// </summary>
public AvsynctestFilterGen framerate(Rational framerate) => this.SetOption("framerate",framerate);
/// <summary>
///  set sample rate (from 8000 to 384000) (default 44100)
/// </summary>
public AvsynctestFilterGen samplerate(int samplerate) => this.SetOptionRange("samplerate", samplerate,8000,384000);
/// <summary>
///  set sample rate (from 8000 to 384000) (default 44100)
/// </summary>
public AvsynctestFilterGen sr(int sr) => this.SetOptionRange("sr", sr,8000,384000);
/// <summary>
///  set beep amplitude (from 0 to 1) (default 0.7)
/// </summary>
public AvsynctestFilterGen amplitude(float amplitude) => this.SetOptionRange("amplitude", amplitude,0,1);
/// <summary>
///  set beep period (from 1 to 99) (default 3)
/// </summary>
public AvsynctestFilterGen period(int period) => this.SetOptionRange("period", period,1,99);
/// <summary>
///  set flash delay (from -30 to 30) (default 0)
/// </summary>
public AvsynctestFilterGen delay(int delay) => this.SetOptionRange("delay", delay,-30,30);
/// <summary>
///  set flash delay (from -30 to 30) (default 0)
/// </summary>
public AvsynctestFilterGen dl(int dl) => this.SetOptionRange("dl", dl,-30,30);
/// <summary>
///  set delay cycle (default false)
/// </summary>
public AvsynctestFilterGen cycle(bool cycle) => this.SetOption("cycle",cycle.ToFFmpegFlag());
/// <summary>
///  set duration (default 0)
/// </summary>
public AvsynctestFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set foreground color (default &quot;white&quot;)
/// </summary>
public AvsynctestFilterGen fg(Color fg) => this.SetOption("fg",fg.ToHexStringRGBA());
/// <summary>
///  set background color (default &quot;black&quot;)
/// </summary>
public AvsynctestFilterGen bg(Color bg) => this.SetOption("bg",bg.ToHexStringRGBA());
/// <summary>
///  set additional color (default &quot;gray&quot;)
/// </summary>
public AvsynctestFilterGen ag(Color ag) => this.SetOption("ag",ag.ToHexStringRGBA());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate an Audio Video Sync Test.
/// </summary>
public static AvsynctestFilterGen AvsynctestFilterGen(this IAudioFilterGraph input0) => new AvsynctestFilterGen(input0);
}
}
