using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task4.V10.Lib {
    public class DataService : ISprint5Task4V10 {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string temp = str.Replace(".", ",");
            double x = Convert.ToDouble(temp);
            double res = Math.Round(Math.Pow(x, 3) * 1.2 * x + 2, 3);
            return res;
        }
    }
}
