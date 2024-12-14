using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GairabekovMR.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;


            if (fileExists)
            {
                File.Delete(path);
            }
            int column, row;
            row = matrix.GetUpperBound(0) + 1;
            column = matrix.Length / row;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j != column - 1)
                    {
                        str = str + matrix[i, j] + ";";

                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }

                }
                if (i != row - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;

        }
    }
}
