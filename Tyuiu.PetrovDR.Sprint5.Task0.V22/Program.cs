using Tyuiu.PetrovDR.Sprint5.Task0.V22.Lib;


namespace Tyuiu.PetrovDR.Sprint5.Task0.V22
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
            PrintCenteredLine("Задание #0", width);
            PrintCenteredLine("Вариант #22", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дано выражение вычислить его значение при x = 3, результат сохранить в текстовый файл", width);
            Console.WriteLine("OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int x = 3;

            Console.WriteLine("x = " + x);

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создaн!");

            Console.ReadKey();
        }
    }
}