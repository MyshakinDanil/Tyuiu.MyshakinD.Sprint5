using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task3.V26.Lib {
    public class DataService : ISprint5Task3V26 {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileexist = fileInfo.Exists;

            if (fileexist)
            {
                File.Delete(path);
            }

            double res = Math.Round(0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
