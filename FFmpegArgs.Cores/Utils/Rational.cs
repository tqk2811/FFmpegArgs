namespace FFmpegArgs.Cores.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class Rational
    {
        /// <summary>
        /// 
        /// </summary>
        public int Numerator { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Denominator { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Rational() { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        public Rational(int num, int den)
        {
            this.Numerator = num;
            this.Denominator = den;
        }
        
        /// <summary>
        /// Create with den = 1
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Rational Create(int num)
           => new Rational(num, 1);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public static Rational Create(int num, int den)
            => new Rational(num, den);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="InvalidRangeException"></exception>
        public Rational Check(double min, double max)
        {
            double rate = (double)Numerator / Denominator;
            if (double.IsNaN(rate) || double.IsInfinity(rate) || rate < min || rate > max)
                throw new InvalidRangeException($"Rational rate InvalidRangeException, required {min} <= {Numerator}/{Denominator} <= {max}");
            return this;
        }
        /// <summary>
        /// Num:Den
        /// </summary>
        /// <returns></returns>
        public string ToStringColon() => $"{Numerator}:{Denominator}";
        
        /// <summary>
        /// Num/Den
        /// </summary>
        /// <returns></returns>
        public string ToStringSlash() => $"{Numerator}/{Denominator}";
        
        /// <summary>
        /// Num/Den
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ToStringSlash();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(int num) => Create(num);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(long num) => Create((int)num);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(float num) => Create((int)num);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(double num) => Create((int)num);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(decimal num) => Create((int)num);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static explicit operator double(Rational r) => (double)r.Numerator / r.Denominator;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static explicit operator float(Rational r) => (float)r.Numerator / r.Denominator;
    }
}
