using Tyuiu.GulienkoPO.Sprint6.Task4.V18.Lib;
namespace Tyuiu.GulienkoPO.Sprint6.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int z = 5;
            double[] d = { 7.76, 7.36, 7.26, 7.90, 15.88, 2.00, 4.35, 5.63, 6.49, 6.49, 6.32 };
            var res = ds.GetMassFunction(a, z);
            CollectionAssert.AreEqual(res, d);
        }
    }
}