using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task0.V17.Lib {
    public class DataService : ISprint5Task0V17 {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double f = Math.Round((2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1), 3);
            File.WriteAllText(path, Convert.ToString(f));
            return path;
        }
    }
}
