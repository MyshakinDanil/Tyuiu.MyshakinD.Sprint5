using Tyuiu.MyshakinD.Sprint5.Task4.V10.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task4.V10.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }
    }
}