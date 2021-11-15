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
        public int X { get; set; }
        public int Y { get; set; }

        public Rational() { }
        public Rational(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Rational Create(int x, int y)
            => new Rational(x,y);

        public Rational Check(double min,double max)
        {
            double rate = (double)X / Y;
            if (double.IsNaN(rate) || double.IsInfinity(rate) || rate < min || rate > max) 
                throw new InvalidRangeException($"Rational rate InvalidRangeException, required {min} <= {X}/{Y} <= {max}");
            return this;
        }

        public override string ToString()
        {
            return $"{X}/{Y}";
        }
    }
}
