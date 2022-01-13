namespace FFmpegArgs.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public static class FilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static string ToFFmpegFlag(this bool flag)
        {
            return flag ? "1" : "0";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static int EnsureOdd(this int input)
        {
            if (input % 2 == 0) throw new InvalidOperationException("required input odd");
            return input;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static int EnsureEven(this int input)
        {
            if (input % 2 != 0) throw new InvalidOperationException("required input even");
            return input;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexStringRGB(this Color color)
        {
            return $"0x{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexStringRGBA(this Color color)
        {
            return $"0x{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}{color.A.ToString("X2")}";
        }


    }
}
