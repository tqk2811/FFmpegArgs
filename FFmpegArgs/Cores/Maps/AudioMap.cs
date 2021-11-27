namespace FFmpegArgs.Cores.Maps
{
    public class AudioMap : BaseMap, IAudio
    {
        public AudioMap(FilterGraph filterGraph, string name) : base(filterGraph, name)
        {

        }

        public override string GetMapOut()
        {
            return IsInput ? $"\"{MapName}:a:{InputIndex}\"" : $"\"[{MapName}]\"";
        }
    }
}
