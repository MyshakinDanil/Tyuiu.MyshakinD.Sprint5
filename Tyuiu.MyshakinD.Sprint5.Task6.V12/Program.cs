using Tyuiu.MyshakinD.Sprint5.Task6.V12.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task6.V12 {
    internal class Program {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V12.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        *");
            Console.WriteLine("* символьных данных. Найти количество удвоенных букв \"нн\" в заданной    *");
            Console.WriteLine("* строке.                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";
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
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество 'нн' = " + res);
        }
    }
}
