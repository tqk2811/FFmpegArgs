namespace FFmpegArgs.Cores.Outputs
{
    public abstract class BaseOutput : BaseOptionFlag
    {
        internal BaseOutput() { }
        public string OutPath { get; protected set; }
    }
}
