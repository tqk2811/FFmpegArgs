using FFmpegArgs.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FFmpegArgs.Test
{
  [TestClass]
  public class ExpressionTest
  {
    [TestMethod]
    public void Test1()
    {
      Expression expression = new Expression(new List<string>() { });
      Assert.AreEqual("2.2 3 max_2 3 / PI * sin_1", expression.Check("sin(max(2.2,3)/3*PI)"));
    }

    [TestMethod]
    public void Test2()
    {
      Expression expression = new Expression(new List<string>() { "w", "h", "W", "H" });
      Assert.AreEqual("w h max_2 W / PI * sin_1 -", expression.Check("-sin(max(w,h)/W*PI)"));
    }

    [TestMethod]
    public void Test3()
    {
      Expression expression = new Expression(new List<string>() { });
      Assert.AreEqual("2 3 4 * max_2 3 / PI * sin_1", expression.Check("sin(max(2,3*4)/3*PI)"));
    }

    [TestMethod]
    public void Test4()
    {
      Expression expression = new Expression(new List<string>() { "t" });
      Assert.AreEqual("t 10 3 60 * between_3", expression.Check("between(t,10,3*60)"));
    }

    [TestMethod]
    public void Test5()
    {
      Expression expression = new Expression(new List<string>() { "t" });
      Assert.AreEqual("t 10 3 60 * between_3", expression.Check("between(t,10,3*60)"));
    }

    [TestMethod]
    public void Test6()
    {
      Expression expression = new Expression(new List<string>() { "t" });
      Assert.AreEqual("t 10 t * 3 3 PI * sin_1 * between_3", expression.Check("between(t,10*t,3*sin(3*PI))"));
    }

    [TestMethod]
    public void Test7()
    {
      Expression expression = new Expression(new List<string>() { "t" });
      Assert.AreEqual("2 t max_2 10 t * 3 3 PI * sin_1 * between_3", expression.Check("between(max(2,t),10*t,3*sin(3*PI))"));
    }
  }
}
