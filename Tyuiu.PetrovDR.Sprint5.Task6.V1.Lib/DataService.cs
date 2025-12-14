using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PetrovDR.Sprint5.Task6.V1.Lib
{
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            int digitCount = 0;

            foreach (char c in fileContent)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }
    }
}