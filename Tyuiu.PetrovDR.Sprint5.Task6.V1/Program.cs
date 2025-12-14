using Tyuiu.PetrovDR.Sprint5.Task6.V1.Lib;

namespace Tyuiu.PetrovDR.Sprint5.Task6.V1
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
            PrintCenteredLine("Задание #6", width);
            PrintCenteredLine("Вариант #1", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан файл,  в котором есть набор символьных данных. Найти количество цифр", width);
            Console.WriteLine("в заданной строке.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V1.txt");

            File.WriteAllText(path, "123 Привет, это тестовая строка 456.");

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}