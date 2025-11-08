using System.Text;
using System.Text.RegularExpressions;

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
        public double Value => Numerator / Denominator;

        /// <summary>
        /// 
        /// </summary>
        public double Numerator { get; }

        /// <summary>
        /// 
        /// </summary>
        public double Denominator { get; }

        /// <summary>
        /// 
        /// </summary>
        public Rational() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        public Rational(double num, double den)
        {
            this.Numerator = num;
            this.Denominator = den;
        }

        /// <summary>
        /// Create with den = 1
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Rational Create(double num)
           => new Rational(num, 1.0);

        /// <summary>
        /// Num:Den or Num/Den
        /// </summary>
        /// <param name="rationalString"></param>
        /// <returns></returns>
        public static Rational Parse(string rationalString)
        {
            return _Parse(rationalString) ?? throw new InvalidDataException($"'{rationalString}' is invalid format");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rationalString"></param>
        /// <param name="rational"></param>
        /// <returns></returns>

        
        public static bool TryParse(
            string rationalString,
#if NET5_0_OR_GREATER
            [NotNullWhen(true)] 
#endif
            out Rational? rational
            )
        {
            rational = _Parse(rationalString);
            return rational is not null;
        }


        static readonly Regex regex_parse = new Regex("^(\\d+\\.\\d+|\\d+)[:/](\\d+\\.\\d+|\\d+)$", RegexOptions.Compiled);
        static Rational _Parse(string rationalString)
        {
            if (string.IsNullOrWhiteSpace(rationalString))
                return null;

            Match match = regex_parse.Match(rationalString.Trim());
            if (match.Success &&
                double.TryParse(match.Groups[1].Value, out double num) &&
                double.TryParse(match.Groups[2].Value, out double den))
            {
                return new Rational(num, den);
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="InvalidRangeException"></exception>
        public Rational Check(double min, double max)
        {
            double rate = Value;
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
        public static implicit operator Rational(uint num) => Create(num);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(long num) => Create(num);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(double num) => Create(num);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        public static implicit operator Rational(decimal num) => Create((double)num);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static explicit operator double(Rational r) => r.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static explicit operator float(Rational r) => (float)r.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static explicit operator decimal(Rational r) => (decimal)r.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        public static explicit operator string(Rational r) => r.ToString();
    }
}
