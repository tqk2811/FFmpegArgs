using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFmpegArgs;
namespace FFmpegArgs.Test.BuildTest
{
    [TestClass]
    public class BuildTestExtension : BaseTest
    {
        [TestMethod]
        public void Test()
        {
            FFmpegArg ffmpegArg = new FFmpegArg()
                //GlobalOptionsExtension
                .LogLevel(LogLevel.quiet)
                .Report()
                .MaxAlloc(1)
                .OverWriteOutput().Y()
                .IgnoreUnknown()
                .FilterThreads(1)
                .FilterComplexThreads(1)
                .Stats()
                .MaxErrorRate(1)
                //AdvancedGlobalOptionsExtension
                .CpuCount(1)
                .HideBanner()
                .RecastMedia()
                .StatsPeriod(TimeSpan.Zero)
                .NoautoConversionFilters()
                .Threads(1)
                .VSync(VSyncMethod.auto)
                ;

            VideoFileInput videoFileInput = new VideoFileInput("abc", 1, 1);
            videoFileInput
                .Acodec("copy")
                .An()
                .Bitexact()
                .Dn()
                .Duration(TimeSpan.Zero)
                .Format(DemuxingFileFormat.aac).F(DemuxingFileFormat.aac)
                .Input("abc")
                .ItsOffset(TimeSpan.Zero)
                .Ss(TimeSpan.Zero)
                .SsEof(TimeSpan.Zero)
                .SsPosition(TimeSpan.Zero)
                .StreamLoop(-1)
                .SwsFlags(SwsFlags.gauss)
                .T(TimeSpan.Zero)
                .To(TimeSpan.Zero)
                .ToPosition(TimeSpan.Zero)
                .Vn()
                ;
            videoFileInput.AudioInputAVStream
                .Ac(1)
                .Ar(1)
                .BitsPerCodedSample(1)
                .BlockAlign(1)
                .Codec("copy")
                .CodecTag(1)
                .Delay(1)
                .FrameNumber(1)
                .GuessLayoutMax(1)
                .HasBFrames(1)
                .RcOverrideCount(1)
                .SliceCount(1)
                ;
            videoFileInput.ImageInputAVStream
               .Aspect(1)
               .BitsPerCodedSample(1)
               .BlockAlign(1)
               .Codec("copy")
               .CodecTag(1)
               .Delay(1)
               .Fps(1)
               .FrameNumber(1)
               .HasBFrames(1)
               .PixFmt(PixFmt.abgr)
               .R(1)
               .RcOverrideCount(1)
               .S(Size.Empty)
               .SliceCount(1)
               ;
            VideoMap videoMap = ffmpegArg.AddVideoInput(videoFileInput);


            VideoFileOutput videoFileOutput = new VideoFileOutput("def", videoMap.ImageMaps.First(), videoMap.AudioMaps.First());
            videoFileOutput
                .Acodec("copy")
                .Aframes(1)
                .An()
                .Aq("Abc")
                .Atag("!1")
                .Bitexact()
                .Dframes(1)
                .Dn()
                .Duration(TimeSpan.Zero)
                .F(MuxingFileFormat.mp3).Format(MuxingFileFormat.mp3)
                .Fs(1)
                .Shortest()
                .ShortestBufDuration(TimeSpan.Zero)
                .Ss(TimeSpan.Zero).SsPosition(TimeSpan.Zero)
                .SwsFlags(SwsFlags.print_info)
                .T(TimeSpan.Zero)
                .Target(MuxingFileFormat.mp3)
                .Timestamp(DateTime.Now)
                .To(TimeSpan.Zero).ToPosition(TimeSpan.Zero)
                .Vcodec("abc")
                .Vframes(1)
                .Vn()
                ;

            videoFileOutput.AudioOutputAVStream
                .Ar(1)
                .Ac(1)
                .B(1)
                .BitsPerCodedSample(1)
                .BlockAlign(1)
                .Bufsize(2)
                .Codec(Codecs.mlp).Codec("abc")
                .CodecTag(1)
                .CutOff(1)
                .Delay(1)
                .FrameNumber(1)
                .FrameSize(1)
                .HasBFrames(1)
                .Maxrate(1)
                .Minrate(1)
                .RcOverrideCount(1)
                .SampleFmt(AVSampleFormat.AV_SAMPLE_FMT_DBL)
                .SliceCount(1)
                ;

            videoFileOutput.ImageOutputAVStream
                .Aspect(1)
                .B(1)
                .Bf(1)
                .BitsPerCodedSample(1)
                .BlockAlign(1)
                .BQfactor(1)
                .BQoffset(1)
                .Bufsize(1)
                .Codec(Codecs.qoi).Codec("abc")
                .CodecTag(1)
                .Delay(1)
                .Fps(1)
                .FpsMax(1)
                .FrameNumber(1)
                .G(1)
                .HasBFrames(1)
                .Maxrate(1)
                .Minrate(1)
                .Pass(1)
                .PassLogFile("a")
                .PixFmt(PixFmt.abgr)
                .Qblur(1)
                .Qcomp(1)
                .Qdiff(1)
                .Qmax(1)
                .Qmin(1)
                .R(1)
                .RcOverride("a")
                .RcOverrideCount(1)
                .S(Size.Empty)
                .SliceCount(1)
                .Top(OutputVStreamTop.Auto)
                ;
        }
    }
}
