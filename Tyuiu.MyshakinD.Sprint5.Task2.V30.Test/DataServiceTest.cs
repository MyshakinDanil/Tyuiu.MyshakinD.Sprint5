using System.IO;
using Tyuiu.MyshakinD.Sprint5.Task2.V30.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task2.V30.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 3, -1, 3 }, 
                { -2, -5, 0 }, 
                { -8, -7, 2 } };
            
            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(matrix));

            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }
    }
}