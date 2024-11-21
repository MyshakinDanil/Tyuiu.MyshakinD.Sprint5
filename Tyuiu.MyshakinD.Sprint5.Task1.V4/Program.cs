using Tyuiu.MyshakinD.Sprint5.Task1.V4.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task1.V4 {
    internal class Program {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            Console.Title = "Спринт #5 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мышакин Данил              | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, произвести табулирования на заданном диапазоне [-5; 5] с  *");
            Console.WriteLine("* шагом 1. Произвести проверку деления на ноль. Округлить до 2 знаков     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
