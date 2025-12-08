using Tyuiu.PetrovDR.Sprint5.Task0.V22.Lib;
using System.IO;

namespace Tyuiu.PetrovDR.Sprint5.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildSaveToFileTextData()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
