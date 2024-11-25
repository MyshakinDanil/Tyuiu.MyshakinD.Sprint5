using Tyuiu.MyshakinD.Sprint5.Task6.V12.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task6.V12.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            int wait = 3;
            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";

            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}