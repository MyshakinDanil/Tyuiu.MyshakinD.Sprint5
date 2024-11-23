using Tyuiu.MyshakinD.Sprint5.Task5.V16.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task5.V16 {
    internal class Program {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            
            Console.Title = "Спринт #5 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V16.txt (файл взять из      *");
            Console.WriteLine("* архива согласно вашему варианту. \r\n\r\nСоздать папку в ручную         *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор        *");
            Console.WriteLine("* значений.Найти максимальное целое число в файле, которое делится на 10. *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений        *");
            Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("Данные:");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = dataService.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
