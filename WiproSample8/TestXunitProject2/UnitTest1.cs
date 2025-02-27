using WiproSample8;
namespace TestXunitProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Employee em = new Employee("Neha", 25);
            string actual = em.name;
            int actual2 = em.age;
            Assert.Equal("Neha", actual);
            Assert.Equal(25, actual2);


        }
    }
}