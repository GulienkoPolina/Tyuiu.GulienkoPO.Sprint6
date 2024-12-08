using Tyuiu.GulienkoPO.Sprint6.Task2.V17.Lib;
namespace Tyuiu.GulienkoPO.Sprint6.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = new double[]
            {
                4.67, 0.43, -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67
            };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}