using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GairabekovMR.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strLine = Regex.Replace(line, @"\b\p{IsCyrillic}+\b", "");
                    }
                    strLine = ", World! This.";

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile; ;
        }
    }
}