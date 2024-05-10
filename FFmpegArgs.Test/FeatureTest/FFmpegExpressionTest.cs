namespace FFmpegArgs.Test.FeatureTest
{
    [TestClass]
    public class FFmpegExpressionTest
    {
        [TestMethod]
        public void Test1()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { });
            expression.Check("sin(max(2.2,3)/3*PI)", out string shuntingYard);
            Assert.AreEqual("2.2 3 max_2 3 / PI * sin_1", shuntingYard);
        }
        [TestMethod]
        public void Test2()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { "w", "h", "W", "H" });
            expression.Check("-sin(max(w,h)/W*PI)", out string shuntingYard);
            Assert.AreEqual("w h max_2 W / PI * sin_1 -", shuntingYard);
        }
        [TestMethod]
        public void Test3()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { });
            expression.Check("sin(max(2,3*4)/3*PI)", out string shuntingYard);
            Assert.AreEqual("2 3 4 * max_2 3 / PI * sin_1", shuntingYard);
        }
        [TestMethod]
        public void Test4()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { "t" });
            expression.Check("between(t,10,3*60)", out string shuntingYard);
            Assert.AreEqual("t 10 3 60 * between_3", shuntingYard);
        }
        [TestMethod]
        public void Test5()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { "t" });
            expression.Check("between(t,10,3*60)", out string shuntingYard);
            Assert.AreEqual("t 10 3 60 * between_3", shuntingYard);
        }
        [TestMethod]
        public void Test6()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { "t" });
            expression.Check("between(t,10*t,3*sin(3*PI))", out string shuntingYard);
            Assert.AreEqual("t 10 t * 3 3 PI * sin_1 * between_3", shuntingYard);
        }
        [TestMethod]
        public void Test7()
        {
            FFmpegExpression expression = new FFmpegExpression(new List<string>() { "t" });
            expression.Check("between(max(2,t),10*t,3*sin(3*PI))", out string shuntingYard);
            Assert.AreEqual("2 t max_2 10 t * 3 3 PI * sin_1 * between_3", shuntingYard);
        }
    }
}
