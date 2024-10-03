using Tyuiu.GulahmedovTE.Sprint1.Task6.V6.Lib;
namespace Tyuiu.GulahmedovTE.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string checkstr = "ребенок упал";
            string waitstr = "ебенок пал";
            var res = ds.DeleteFirstLetter(checkstr);
            Assert.AreEqual(waitstr, res);

        }
    }
}