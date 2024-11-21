using System.IO;
using Tyuiu.MyshakinD.Sprint5.Task1.V4.Lib;

namespace Tyuiu.MyshakinD.Sprint5.Task1.V4.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(-5, 5));

            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }
    }
}