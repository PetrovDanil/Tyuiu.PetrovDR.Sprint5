using Tyuiu.PetrovDR.Sprint5.Task4.V6.Lib;


namespace Tyuiu.PetrovDR.Sprint5.Task4.V6
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
            PrintCenteredLine("Задание #4", width);
            PrintCenteredLine("Вариант #6", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан файл, в котором есть вещественное значение. Прочитать значение из файла и", width);
            Console.WriteLine("подставить вместо Х в формуле. Вычислить значение по формуле и вывести", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V6.txt");

            File.WriteAllText(path, "2.24");

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}