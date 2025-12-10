using Tyuiu.PetrovDR.Sprint5.Task3.V13.Lib;


namespace Tyuiu.PetrovDR.Sprint5.Task3.V13
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
            PrintCenteredLine("Задание #3", width);
            PrintCenteredLine("Вариант #13", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл", width);
            Console.WriteLine("OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            string res = ds.SaveToFileTextData(3);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создaн!");

            Console.ReadKey();
        }
    }
}