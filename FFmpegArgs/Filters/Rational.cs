using FFmpegArgs.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters
{
    public class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Rational() { }
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
        public static Rational Create(int num, int den)
            => new Rational(num,den);

        public Rational Check(double min, double max)
        {
            double rate = (double)Numerator / Denominator;
            if (double.IsNaN(rate) || double.IsInfinity(rate) || rate < min || rate > max) 
                throw new InvalidRangeException($"Rational rate InvalidRangeException, required {min} <= {Numerator}/{Denominator} <= {max}");
            return this;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static implicit operator Rational(int num) => Create(num);
        public static implicit operator Rational(long num) => Create((int)num);
        public static implicit operator Rational(float num) => Create((int)num);
        public static implicit operator Rational(double num) => Create((int)num);
        public static implicit operator Rational(decimal num) => Create((int)num);
    }
}
