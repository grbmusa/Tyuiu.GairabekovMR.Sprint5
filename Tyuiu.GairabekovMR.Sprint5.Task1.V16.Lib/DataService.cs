using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GairabekovMR.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            while (startValue <= stopValue)
            {
                double result = Math.Sin(startValue) + (2 * startValue) / 3 - Math.Cos(startValue) * 4 * startValue;
                if (double.IsInfinity(result) || double.IsNaN(result))
                    result = 0;
                result = Math.Round(result, 2);

                File.AppendAllText(path, $"{result.ToString()}\n");
                startValue++;
            }

            return path;
        }
    }
}
