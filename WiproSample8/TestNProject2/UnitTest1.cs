using Moq;
using WiproSample8;
namespace TestNProject2
{
    public class Tests
    {
        public int i = 50, j = 10;
        public bool result;

        [SetUp]
        public void CheckNonNegative()
        {
            if (i > 0 && j > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        [Test]
        public void TestAdd()
        {
            if (result)
            {
                MathOP mop = new MathOP();
                int res = mop.Add(i, j);
                Assert.That(res, Is.EqualTo(60));

            }
            else
            {
                Assert.Fail();
            }

        }

       
        [Test]
        [Ignore("Not yet Implemented")]
        public void TestSub()
        {

        }

        [Test]
        public void MockTest()
        {
            Mock<MathOP> m = new Mock<MathOP>();
            m.Setup(x => x.CheckValues()).Returns(true);
            Assert.That(m.Object.CheckValues(), Is.EqualTo(true));
        }
    }
}