namespace FFmpegArgs.Cores.Maps
{
    public class ImageMap : BaseMap , IImage
    {
        public ImageMap(FilterGraph filterGraph, string name) : base(filterGraph, name)
        {

        }

        public override string GetMapOut()
        {
            return IsInput ? $"\"{MapName}:v:{InputIndex}\"" : $"\"[{MapName}]\"";
        }
    }
}
