using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MyshakinD.Sprint5.Task7.V10.Lib {
    public class DataService : ISprint5Task7V10 {
        public string LoadDataAndSave(string path)
        {
            string resPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            FileInfo fileInfo = new FileInfo(resPath);
            bool fileexist = fileInfo.Exists;

            if (fileexist)
            {
                File.Delete(resPath);
            }

            string strline = "";
            using (StreamReader  reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(c))
                        {
                            strline += Char.ToLower(c);
                        }
                        else
                        {
                            strline += c;
                        }
                    }
                    File.AppendAllText(resPath, strline);
                    strline = "";
                }
            }
            return resPath;
        }
    }
}
