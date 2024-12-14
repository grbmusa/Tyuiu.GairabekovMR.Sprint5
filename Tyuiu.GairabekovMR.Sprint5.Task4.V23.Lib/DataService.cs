using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GairabekovMR.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string n = File.ReadAllText(path);
            double x = double.Parse(n.Replace('.', ','));
            double result = Math.Pow(x, -3) + 2 + Math.Cos(x);
            return Math.Round(result, 3);
        }
    }
}