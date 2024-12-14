using Tyuiu.GairabekovMR.Sprint5.Task0.V29.Lib;


namespace Tyuiu.GairabekovMR.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | Выполнил: Гайрабеков | ИИПБ-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл.                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Гайрабеков | ИИПБ-24-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 6.1x^3 + 0.23x^2 + 1.04x, вычислить его значение  *");
            Console.WriteLine("* при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt     *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");

            int x = 3;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан.");

            Console.ReadKey();
        }
    }
}
