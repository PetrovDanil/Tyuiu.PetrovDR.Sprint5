using Tyuiu.PetrovDR.Sprint5.Task2.V12.Lib;



namespace Tyuiu.PetrovDR.Sprint5.Task2.V12
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
            PrintCenteredLine("Задание #2", width);
            PrintCenteredLine("Вариант #12", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            Console.WriteLine("Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры.", width);
            Console.WriteLine("Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);

            int[,] matrix = { { -5, -5, 9 }, { -7, 3, -4 }, { 8, 7, 9 } };

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создaн!");

            Console.ReadKey();
        }
    }
}