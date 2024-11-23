using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task5.V16.Lib {
    public class DataService : ISprint5Task5V16 {
        public double LoadFromDataFile(string path)
        {
            double res = -999;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    double num = Math.Round(Convert.ToDouble(line), 3);
                    if (num > res && num % 10 == 0)
                    {
                        res = num;
                    }
                }
            }
            return res;
        }
    }
}
