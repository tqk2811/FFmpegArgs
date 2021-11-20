namespace FFmpegArgs.Cores.Outputs
{
    public abstract class BaseOutput : BaseInputOutput
    {
        internal BaseOutput() { }
        public string OutPath { get; protected set; }
    }
}
