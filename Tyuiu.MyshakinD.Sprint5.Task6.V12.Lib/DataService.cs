using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task6.V12.Lib {
    public class DataService : ISprint5Task6V12 {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == 'н' && line[i + 1] == 'н')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
