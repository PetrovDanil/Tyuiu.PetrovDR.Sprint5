using Tyuiu.PetrovDR.Sprint5.Task5.V4.Lib;

namespace Tyuiu.PetrovDR.Sprint5.Task5.V4
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
            PrintCenteredLine("Задание #5", width);
            PrintCenteredLine("Вариант #4", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан файл,  в котором есть набор значений. Найти произведение всех вещественных", width);
            Console.WriteLine("чисел в файле.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V4.txt");

            File.WriteAllText(path, "-7.95 16.41 19 11 10.92 -4 -4.39 9.89 13 8 8 -10 -1 9.9 -3.01 12.35 -4 -7.28 -4.57 -8");

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}