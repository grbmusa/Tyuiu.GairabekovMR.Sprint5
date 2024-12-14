using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GairabekovMR.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double f = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;

            f = Math.Round(f, 2);
            File.WriteAllText(path, Convert.ToString(f));

            return path;
        }
    }
}