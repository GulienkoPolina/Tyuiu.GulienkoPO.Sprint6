using Tyuiu.GulienkoPO.Sprint6.Task3.V26.Lib;
namespace Tyuiu.GulienkoPO.Sprint6.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mt = { { 16, 19, 17 }, { 1, 2, 5 }, { 2, 4, 6, } };
            int[,] res = ds.Calculate(mt);
            int[,] wait = { { 16, 19, 17 }, { 1, 2, 5 }, { 0, 0, 0, } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}