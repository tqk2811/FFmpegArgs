# FFmpegArgs

Easy to use
``` Csharp
FilterGraph filterGraph = new FilterGraph();
filterGraph.OverWriteOutput();

var green_video = filterGraph.AddVideoInput(new VideoFileInput(@"chromakey.mp4"));
var background_video = filterGraph.AddVideoInput(new VideoFileInput(@"background.mp4"));

var green_fix = green_video.ImageMaps.First()
	.ColorKeyFilter(Color.FromArgb(101, 220, 8)).Similarity(0.25f)//ColorKey
	.Enable("between(t,0,10)").MapOut//ITimelineSupport
	.ScaleFilter("iw/3", "ih/3").MapOut;//Scale

var overlay = green_fix
	.OverlayFilterOn(background_video.ImageMaps.First(), "0", "0").MapOut;//overlay at x=0 and y=0

var videoOutput = new VideoFileOutput(@"out.mp4", overlay, background_video.AudioMaps.First());
filterGraph.AddOutput(videoOutput);

var args = filterGraph.GetFullCommandline();
```

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
    internal PadFilter(Action<Expression> w, Action<Expression> h, IImageMap imageMap) : base("pad", imageMap)
    {
        _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{FilterIndex}"));
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
    public static PadFilter PadFilter(this IImageMap imageMap, Action<Expression> w, Action<Expression> h)
    {
        return new PadFilter(w, h, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
}


//input
public static T FrameRate<T>(this T output, int r) where T : BaseInput
    => output.SetOption("-r", r);

//output
public static T VSync<T>(this T output,int vsync) where T : BaseOutput, IImageOutput
    => output.SetOption("-vsync", vsync);
public static T ASync<T>(this T output, int async) where T : BaseOutput, IAudioOutput
    => output.SetOption("-async", async);

//global 
public static FilterGraph OverWriteOutput(this FilterGraph filterGraph)
    => filterGraph.SetFlag("-y");
```

ffmpeg expression check
``` Csharp
img.ScaleFilter("iw/3", "ih/3")//auto check with expression
//or
img.ScaleFilter(w => w.Check("iw/3"), h => h.Check("ih/3"))
//if expression bropblem
img.ScaleFilter(w => w.NonCheck("iw/3"), h => h.NonCheck("ih/3"));
```


# LICENCE  
Under [ffmpeg](https://github.com/FFmpeg/FFmpeg) licence
