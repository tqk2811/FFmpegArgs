namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageOutputAVStream : OutputAVStream, IImage
    {
        /// <summary>
        /// 
        /// </summary>
        public ImageMap ImageMap { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageOutputAVStream(ImageMap imageMap) : base(imageMap)
        {
            this.ImageMap = imageMap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            List<string> options = base._options.Select(x => $"{x.Key} {x.Value}").ToList();
            options.AddRange(base._flags.Select(x => x));
            if (this.ImageMap.IsInput) options.Add($"-map {this.ImageMap.MapName}");
            else options.Add($"-map [{this.ImageMap.MapName}]");
            return string.Join(" ", options);
        }
    }
}
