using System;
namespace FFmpegArgs.Expressions
{
    public class ShuntingYardFunction
    {
        public ShuntingYardFunction(string name, string sy)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrEmpty(sy)) throw new ArgumentNullException(nameof(sy));
            this.Name = name;
            this.SY = sy;
        }
        public string Name { get; set; }
        public string SY { get; set; }
    }
}
