namespace FFmpegArgs.Cores.Outputs
{
  public abstract class BaseOutput : BaseOptionFlag, IMediaOutput
  {
    public virtual string OutPath { get; }
  }
}
