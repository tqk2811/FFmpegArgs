namespace FFmpegArgs.Filters.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    public class ShuntingYardFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sy"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ShuntingYardFunction(string name, string sy)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrEmpty(sy)) throw new ArgumentNullException(nameof(sy));
            this.Name = name;
            this.SY = sy;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SY { get; set; }
    }
}
