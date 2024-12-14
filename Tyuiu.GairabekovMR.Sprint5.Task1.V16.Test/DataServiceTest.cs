using Tyuiu.GairabekovMR.Sprint5.Task1.V16.Lib;
using System.IO;
namespace Tyuiu.GairabekovMR.Sprint5.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask1.txt");


            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}