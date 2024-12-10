using Tyuiu.GulienkoPO.Sprint6.Task7.V28.Lib;
namespace Tyuiu.GulienkoPO.Sprint6.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.GulienkoPO.Sprint6\DataSprint6\InPutDataFileTask7V28.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}