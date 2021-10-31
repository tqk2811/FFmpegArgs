namespace FFmpegArgs.Cores.Maps
{

  public abstract class BaseMap : IBaseMap
  {
    public FilterGraph FilterGraph { get; }

    /// <summary>
    /// if video input (sound and video), it auto select by filter
    /// </summary>
    public string MapName { get; }

    public bool IsInput { get; internal set; } = false;

    public int InputIndex { get; internal set; } = 0;

    internal BaseMap(FilterGraph filterGraph, string name)
    {
      this.FilterGraph = filterGraph;
      this.MapName = name;
    }
  }
}
