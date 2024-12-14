using Tyuiu.GairabekovMR.Sprint5.Task4.V23.Lib;
namespace Tyuiu.GairabekovMR.Sprint5.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Гайрабеков | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5");
            Console.WriteLine("* Тема: Чтение данных");
            Console.WriteLine("* Задание #4");
            Console.WriteLine("* Вариант #23");
            Console.WriteLine("* Выполнил: Гайрабеков | ИИПБ-24-2");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) " +
                "и вернуть полученный результат на консоль.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask4V23.txt");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Данные находятся в: {path}");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Ответ:" + res);
            Console.ReadKey();
        }
    }
}
