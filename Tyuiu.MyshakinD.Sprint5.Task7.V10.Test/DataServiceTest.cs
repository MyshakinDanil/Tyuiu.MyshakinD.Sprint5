namespace Tyuiu.MyshakinD.Sprint5.Task7.V10.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileexist = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }
    }
}