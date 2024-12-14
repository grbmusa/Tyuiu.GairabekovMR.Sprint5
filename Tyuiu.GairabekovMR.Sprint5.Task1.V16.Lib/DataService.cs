using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GairabekovMR.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;

            for (double x = startValue; x <= stopValue; x++)
            {
                int numDigitsAfterPoint = 2;

                y = Math.Sin(x) + ((2.0 * x) / 3.0) - (Math.Cos(x) * 4.0 * x);
                y = Math.Round(y, 2);
                string result = y.ToString("0." + new string('0', numDigitsAfterPoint));

                if (x != stopValue)
                {
                    File.AppendAllText(path, result + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, result);
                }
                if (double.IsInfinity(y) || double.IsNaN(y))
                {
                    y = 0;
                }

            }
            return path;
        }
    }
}
