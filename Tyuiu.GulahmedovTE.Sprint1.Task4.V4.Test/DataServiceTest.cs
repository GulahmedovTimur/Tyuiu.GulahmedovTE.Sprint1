using Tyuiu.GulahmedovTE.Sprint1.Task4.V4.Lib;
namespace Tyuiu.GulahmedovTE.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);
            double result = Math.Abs(x + 2);
            Assert.AreEqual(0.75, res);

        }
    }
}