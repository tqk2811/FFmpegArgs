# FFmpegArgs

Easy to use
``` Csharp
FilterGraph filterGraph = new FilterGraph().OverWriteOutput();

var green_video = filterGraph.AddVideoInput(new VideoFileInput(@"chromakey.mp4")
    .SsPosition(TimeSpan.FromSeconds(0.5)));
var background_video = filterGraph.AddVideoInput(new VideoFileInput(@"background.mp4")
    .SsPosition(TimeSpan.FromSeconds(1))
    .ToPosition(TimeSpan.FromSeconds(10)));

var color_keys = green_video.ImageMaps.First()
    .ColorKeyFilter(Color.FromArgb(101, 220, 8)).Similarity(0.25f)//ColorKey
        .Enable("between(t,0,10)").MapOut//ITimelineSupport
    .ScaleFilter("iw/3", "ih/3").MapOut
    .SplitFilter(2).MapsOut;//Scale

var overlay = color_keys.First()
    //overlay color_key on-center background_video
    .OverlayFilterOn(background_video.ImageMaps.First(), "(W-w)/2", "(H-h)/2").MapOut;

filterGraph.AddOutput(new VideoFileOutput(@"out.mp4", overlay, background_video.AudioMaps.First()).Fps(24));
filterGraph.AddOutput(new VideoFileOutput(@"out2.mp4", color_keys.Last(), background_video.AudioMaps.First()).Fps(30));

var args = filterGraph.GetFullCommandline();
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
    readonly Expression expression = new Expression(_variables);
    internal PadFilter(Action<Expression> w, Action<Expression> h, ImageMap imageMap) : base("pad", imageMap)
    {
        AddMapOut();
        this.SetOption("w", w.Run(expression));
        this.SetOption("h", h.Run(expression));
    }

    public PadFilter Position(Action<Expression> x, Action<Expression> y)
        => this.SetOption("x", x.Run(expression)).SetOption("y", y.Run(expression));

    public PadFilter Position(string x, string y)
        => Position(x.Expression(), y.Expression());

    public PadFilter Color(Color color)
        => this.SetOption("color", color.ToHexStringRGBA());

    public PadFilter Eval(ScaleEval eval)
        => this.SetOption("eval", eval.ToString().ToLower());
}

public static class PadFilterExtension
{
    public static PadFilter PadFilter(this ImageMap imageMap, Action<Expression> w, Action<Expression> h)
    {
        return new PadFilter(w, h, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
}


//input
public static T FrameRate<T>(this T output, int r) where T : BaseInput
    => output.SetOption("-r", r);

//output
public static T VSync<T>(this T output,int vsync) where T : ImageOutput
    => output.SetOption("-vsync", vsync);
public static T ASync<T>(this T output, int async) where T : AudioOutput
    => output.SetOption("-async", async);

//global 
public static FilterGraph OverWriteOutput(this FilterGraph filterGraph)
    => filterGraph.SetFlag("-y");
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
Under [ffmpeg](https://github.com/FFmpeg/FFmpeg) licence
