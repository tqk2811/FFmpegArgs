namespace FFmpegArgs
{
  public static class FilterGraphExtension
  {
    public static FilterGraph OverWriteOutput(this FilterGraph filterGraph)
      => filterGraph.SetFlag("-y");







  }
}
