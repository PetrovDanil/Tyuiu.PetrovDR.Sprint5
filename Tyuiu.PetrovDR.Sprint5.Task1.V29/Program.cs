using Tyuiu.PetrovDR.Sprint5.Task1.V29.Lib;


namespace Tyuiu.PetrovDR.Sprint5.Task1.V29
{
    class Program
    {

        static void Main(string[] args)
        {
            void PrintCenteredLine(string text, int totalWidth)
            {
                var padding = totalWidth - text.Length - 2;
                Console.WriteLine($"* {text}{new string(' ', padding)}*");
            }
            var width = 100;



            DataService ds = new DataService();

            PrintCenteredLine("Спринт #5 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #5", width);
            PrintCenteredLine("Тема: Обработка файлов", width);
            PrintCenteredLine("Задание #1", width);
            PrintCenteredLine("Вариант #29", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дана функция, произвести табулирование, проверку деления на ноль(результат 0),", width);
            Console.WriteLine("на диапазоне -5:5, шаг 1, два знака после запятой, результат в файл", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создaн!");

            Console.ReadKey();
        }
    }
}