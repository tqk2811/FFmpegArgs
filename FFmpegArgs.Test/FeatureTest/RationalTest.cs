using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Test.FeatureTest
{
    [TestClass]
    public class RationalTest : BaseTest
    {
        [TestMethod]
        public void TestParse()
        {
            Rational rational = null;
            Assert.IsTrue(Rational.TryParse("2000:10", out rational));
            Assert.IsTrue(Rational.TryParse("2000.04635:10", out rational));
            Assert.IsTrue(Rational.TryParse("2000/0", out rational));
            Assert.IsTrue(Rational.TryParse("2000.5261/10", out rational));
        }
    }
}
