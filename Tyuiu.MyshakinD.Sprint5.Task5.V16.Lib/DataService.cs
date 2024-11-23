using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task5.V16.Lib {
    public class DataService : ISprint5Task5V16 {
        public double LoadFromDataFile(string path)
        {
            double res = double.NegativeInfinity;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    if (Convert.ToDouble(line) > res && Convert.ToDouble(line) % 10 == 0)
                    {
                        res = Convert.ToDouble(line);
                    }
                }
            }
            return res;
        }
    }
}
