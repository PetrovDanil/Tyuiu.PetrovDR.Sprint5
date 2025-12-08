using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PetrovDR.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;


            if (fileExists)
            {
                File.Delete(path);
            }


            double y;
            string strY;
            
            
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2, 2);
                if (x + 1.2 == 0)
                {
                    y = 0;
                }

                strY = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);

                }
                else
                {
                    File.AppendAllText(path, strY);
                }

            }
            return path;
        }
    }
}