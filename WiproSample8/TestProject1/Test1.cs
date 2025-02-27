
using WiproSample8;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MathOP mth=new MathOP();
            int res = mth.Add(20, 20);
            Assert.AreEqual(res, 40);
        }

        [TestMethod]
        public void TestMethod2() {
            MathOP mth=new MathOP();
            int res = mth.Sub(30, 20);
            Assert.AreEqual(res, 0);

        
        }

    }
}
