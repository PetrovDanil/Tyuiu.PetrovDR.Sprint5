using Tyuiu.PetrovDR.Sprint5.Task7.V19.Lib;


namespace Tyuiu.PetrovDR.Sprint5.Task7.V19
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
            PrintCenteredLine("Задание #7", width);
            PrintCenteredLine("Вариант #19", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан файл,  в котором есть набор символьных данных. Удалить все удвоенные", width);
            Console.WriteLine("буквы 'cc' из файла.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V19.txt");

            File.WriteAllText(path, "Ссловарные сслова сс удвоенной ссогласной нн");

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат в файле: " + res);

            Console.ReadKey();
        }
    }
}