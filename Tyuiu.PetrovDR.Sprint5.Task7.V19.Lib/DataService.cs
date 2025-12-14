using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PetrovDR.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {

            string save = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });

            FileInfo fileInfo = new FileInfo(save);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(save);
            }



            string fileContent = File.ReadAllText(path);

            string cond = fileContent.Replace("сс", "").Replace("Сс", "").Replace("СС", "");

            File.WriteAllText(save, cond);
            return save;
        }
    }
}