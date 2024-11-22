using Tyuiu.MyshakinD.Sprint5.Task3.V26.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task3.V26.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;

            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(2));

            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }
    }
}