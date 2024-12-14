using Tyuiu.GairabekovMR.Sprint5.Task2.V2.Lib;

namespace Tyuiu.GairabekovMR.Sprint5.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { {-7,7,5 },
                                          {4,2,-7 },
                                          {2,6,-4 }};
            var res = ds.SaveToFileTextData(mtrx);
            string wait = "0;1;1\r\n" +
                "1;1;0\r\n" +
                "1;1;0";
            Assert.AreEqual(wait, File.ReadAllText(res));
        }
    }
}