using Tyuiu.MyshakinD.Sprint5.Task7.V10.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task7.V10 {
    internal class Program {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #5 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V10.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        *");
            Console.WriteLine("* символьных данных.Заменить все заглавные латинские буквы на строчные.   *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V10.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("Данные:");
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string resPath = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат сохранен в файл:");
            Console.WriteLine(resPath);
            Console.WriteLine("Результат:");

            using (StreamReader sr = new StreamReader(resPath))
            {
                string line;
                while ( ((line = sr.ReadLine()) != null) )
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
