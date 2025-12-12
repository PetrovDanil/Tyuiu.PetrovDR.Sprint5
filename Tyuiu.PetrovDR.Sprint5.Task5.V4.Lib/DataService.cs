using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PetrovDR.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lineReplace = line.Replace('.', ',');
                    string[] lineArray = lineReplace.Split(' ');

                    foreach (string number in lineArray)
                    {
                        double lineParse = double.Parse(number);

                        if (lineParse % 1 != 0)
                        {
                            res = res * lineParse;
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}