using Tyuiu.MyshakinD.Sprint5.Task0.V17.Lib;
using System.IO;

namespace Tyuiu.MyshakinD.Sprint5.Task0.V17.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;

            FileInfo fileinfo = new FileInfo(ds.SaveToFileTextData(x));
            bool fileexist = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileexist);
        }
    }
}