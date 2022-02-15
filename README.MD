# FFmpegArgs

[NuGet Package](https://www.nuget.org/packages?q=FFmpegArgs)  
[Github Repo](https://github.com/tqk2811/FFmpegArgs)
________________________________________
Easy to use
``` Csharp
FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();

var green_video = ffmpegArg.AddVideoInput(new VideoFileInput(@"chromakey.mp4")
    .SsPosition(TimeSpan.FromSeconds(0.5)));
var background_video = ffmpegArg.AddVideoInput(new VideoFileInput(@"background.mp4")
    .SsPosition(TimeSpan.FromSeconds(1))
    .ToPosition(TimeSpan.FromSeconds(10)));

var color_keys = green_video.ImageMaps.First()
    .ColorKeyFilter().Color(Color.FromArgb(101, 220, 8)).Similarity(0.25f)//ColorKey
        .Enable("between(t,0,10)").MapOut//ITimelineSupport
    .ScaleFilter().W("iw/3").H("ih/3").MapOut
    .SplitFilter(2).MapsOut;//Scale

var overlay = color_keys.First()
    //overlay color_key on-center background_video
    .OverlayFilterOn(background_video.ImageMaps.First()).X("(W-w)/2").Y("(H-h)/2").MapOut;

ffmpegArg.AddOutput(new VideoFileOutput(@"out.mp4", overlay, background_video.AudioMaps.First()).Fps(24));
ffmpegArg.AddOutput(new VideoFileOutput(@"out2.mp4", color_keys.Last(), background_video.AudioMaps.First()).Fps(30));

var renderResult = ffmpegArg
    .Render(c => c
        .WithFFmpegBinaryPath("path to ffmpeg.exe")
        .WithWorkingDirectory(Directory.GetCurrentDirectory()))
    .Execute();
```
For more example, see `FFmpegArgs.Test`  

________________________________________
Easy extend

``` Csharp
//filter
public class PadFilter : ImageToImageFilter
{
    static readonly IEnumerable<string> _variables = new List<string>()
    {
        "in_w", "in_h", "iw", "ih",
        "out_w", "out_h", "ow", "oh",
        "x","y","a","sar","dar",
        "hsub", "vsub"
    };
    readonly FFmpegExpression expression = new FFmpegExpression(_variables);
    internal PadFilter(ImageMap imageMap) : base("pad", imageMap)
    {
        AddMapOut();
    }

    public PadFilter XY(Action<FFmpegExpression> x, Action<FFmpegExpression> y)
        => this.SetOption("x", x.Run(expression)).SetOption("y", y.Run(expression));

    public PadFilter XY(string x, string y)
        => XY(x.Expression(), y.Expression());

    public PadFilter Color(Color color)
        => this.SetOption("color", color.ToHexStringRGBA());

    public PadFilter Eval(ScaleEval eval)
        => this.SetOption("eval", eval.ToString().ToLower());
}

public static class PadFilterExtension
{
    public static PadFilter PadFilter(this ImageMap imageMap)
    {
        return new PadFilter(imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
}


//input
public static T FrameRate<T>(this T input, int r) where T : BaseInput
    => input.SetOption("-r", r);

//output
public static T VSync<T>(this T output,int vsync) where T : ImageOutput
    => output.SetOption("-vsync", vsync);
public static T ASync<T>(this T output, int async) where T : AudioOutput
    => output.SetOption("-async", async);

//global 
public static FFmpegArg OverWriteOutput(this FFmpegArg ffmpegArg)
    => ffmpegArg.SetFlag("-y");
```

ffmpeg expression check
``` Csharp
//auto check with expression
img.ScaleFilter("iw/3", "ih/3")
//or
img.ScaleFilter(w => w.Check("iw/3"), h => h.Check("ih/3"))
//if expression bropblem
img.ScaleFilter(w => w.NonCheck("iw/3"), h => h.NonCheck("ih/3"));
```


# LICENCE  
MIT
