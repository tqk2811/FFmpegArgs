# FFmpegArgs
**FFmpegArgs** is a cli-wrapper library support generate argument for ffmpeg executable.  
The standout feature that many cli-wrapper libraries don't have is the **FFmpeg FilterGraph** system.

Get it on [NuGet Package](https://www.nuget.org/packages?q=FFmpegArgs)  
________________________________________  
- Support file/url/pipe in/output.
- Works on most systems - if ffmpeg can execution.
- 130+ filters, add more in future 
- 380+ filters auto-generate

# Example
``` Csharp
FFmpegArg ffmpegArg = new FFmpegArg().OverWriteOutput();

var green_video = ffmpegArg.AddVideoInput(new VideoFileInput(@"chromakey.mp4")
    .SsPosition(TimeSpan.FromSeconds(0.5)));
var background_video = ffmpegArg.AddVideoInput(new VideoFileInput(@"background.mp4")
    .SsPosition(TimeSpan.FromSeconds(1))
    .ToPosition(TimeSpan.FromSeconds(10)));

var color_keys = green_video.ImageMaps.First()
    .ColorKeyFilter()//ColorKey
        .Color(Color.FromArgb(101, 220, 8))
        .Similarity(0.25f)
        .Enable("between(t,0,10)").MapOut//ITimelineSupport
    .ScaleFilter().W("iw/3").H("ih/3").MapOut//Scale
    .SplitFilter(2).MapsOut;//Split

var overlay = color_keys.First()
    //overlay color_key on-center background_video
    .OverlayFilterOn(background_video.ImageMaps.First()).X("(W-w)/2").Y("(H-h)/2").MapOut;

ffmpegArg.AddOutput(new VideoFileOutput(@"out.mp4", overlay, background_video.AudioMaps.First()).Fps(24));
ffmpegArg.AddOutput(new VideoFileOutput(@"out2.mp4", color_keys.Last(), background_video.AudioMaps.First()).Fps(30));

var renderResult = ffmpegArg
    .Render(c => c
        .WithFFmpegBinaryPath("path to ffmpeg")
        .WithWorkingDirectory(Directory.GetCurrentDirectory()))
    .Execute();
```
For more example, see `FFmpegArgs.Test`  

----------------------------------------
+ Option/Flag not found?  

We can extend for `FFmpegArg`, `Filter`, `Input`, `Output` by extension.  

`.SetOption("your option","option value")`  
`.SetOptionRange("your option", val, min, max)`  
`.SetFlag("your flag")`  

+ Filter not found?  

We can write new Filter class, so much example in `FFmpegArgs.Filters`  

Pull request or request missing feature are welcome.

----------------------------------------
Recommend namespace for extension  
```csharp
FFmpegArgs;
FFmpegArgs.Cores;
FFmpegArgs.Cores.Enums;
FFmpegArgs.Cores.Exceptions;
FFmpegArgs.Cores.Inputs;
FFmpegArgs.Cores.Filters;
FFmpegArgs.Cores.Maps;

FFmpegArgs.Filters;
FFmpegArgs.Filters.Exceptions;
FFmpegArgs.Filters.Attributes;
FFmpegArgs.Filters.Expressions;
FFmpegArgs.Filters.FilterGraphs;

FFmpegArgs.Filters.AudioFilters;
FFmpegArgs.Filters.VideoFilters;
FFmpegArgs.Filters.MultimediaFilters;
FFmpegArgs.Filters.VideoSources;
FFmpegArgs.Filters.AudioSources;
//FFmpegArgs.Filters.Autogens;

FFmpegArgs.Executes;
FFmpegArgs.Inputs;
FFmpegArgs.Outputs;

```
________________________________________

# LICENCE  
MIT
