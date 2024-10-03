using Tyuiu.GulahmedovTE.Sprint1.Task2.V18.Lib;
namespace Tyuiu.GulahmedovTE.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int length = 2;
            int width = 3;
            int height = 4;
            int expected = 2 * height * (length + width); // 2 * 4 * (2 + 3) = 40

            int actual = ds.CalculateSideSquareParallelepiped(length, width, height);

            Assert.AreEqual(expected, actual);
        }
    }
}