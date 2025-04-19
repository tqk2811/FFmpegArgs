namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... zmq               V-&gt;V       Receive commands through ZMQ and broker them to filters.
/// </summary>
public class ZmqFilterGen : ImageToImageFilter
{
internal ZmqFilterGen(ImageMap input) : base("zmq",input) { AddMapOut(); }
/// <summary>
///  Maximum send/read packet size (from -1 to INT_MAX) (default 131072)
/// </summary>
public ZmqFilterGen pkt_size(int pkt_size) => this.SetOptionRange("pkt_size", pkt_size,-1,INT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Receive commands through ZMQ and broker them to filters.
/// </summary>
public static ZmqFilterGen ZmqFilterGen(this ImageMap input0) => new ZmqFilterGen(input0);
}
}
