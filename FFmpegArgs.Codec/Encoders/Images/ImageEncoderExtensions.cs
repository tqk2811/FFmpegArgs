/*
H264 Decoder AVOptions:
  -is_avc            <boolean>    .D.V..X.... is avc (default false)
  -nal_length_size   <int>        .D.V..X.... nal_length_size (from 0 to 4) (default 0)
  -enable_er         <boolean>    .D.V....... Enable error resilience on damaged frames (unsafe) (default auto)
  -x264_build        <int>        .D.V....... Assume this x264 version if no x264 version found in any SEI (from -1 to INT_MAX) (default -1)
*/
//ffmpeg -y -c:v:0 h264 -gpu_copy:v:0 0 -deint:v:0 1 -i "2024-10-13 01-51-32 - Copy (2).mp4" test.mp4
//ffmpeg -y -c:v:0 libopenh264 -gpu_copy:v:0 0 -deint:v:0 1 -i "2024-10-13 01-51-32 - Copy (2).mp4" -t 10 -c:v:0 h264_qsv test.mp4
namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ImageEncoderExtensions
    {

    }
}
