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
            string path = @"C:\Users\olilh\source\repos\PetrovDanil\Tyuiu.PetrovDR.Sprint5\Tyuiu.PetrovDR.Sprint5.Task0.V22\bin\Debug\net8.0\OutPutFileTask0.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
