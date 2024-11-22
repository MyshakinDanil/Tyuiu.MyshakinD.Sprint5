using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task2.V30.Lib {
    public class DataService : ISprint5Task2V30 {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileexist = fileInfo.Exists;

            if (fileexist)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int colums = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] > 0) {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                }

                if (i != rows - 1)
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
