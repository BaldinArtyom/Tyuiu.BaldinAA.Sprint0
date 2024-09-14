using Tyuiu.BaldinAA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BaldinAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Artyom";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hi, Artyom", res);

        }
    }
}