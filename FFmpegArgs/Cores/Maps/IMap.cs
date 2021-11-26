namespace FFmpegArgs.Cores.Maps
{
    public interface IMap
    {
        FilterGraph FilterGraph { get; }
        string MapName { get; }
        bool IsInput { get; }
        int InputIndex { get; }
        bool IsMapped { get; }
        string GetMapOut();
    }
}
