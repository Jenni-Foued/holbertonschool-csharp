using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(MyMath.Operations.Add(1, 2), 3);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(MyMath.Operations.Add(1, -2), -1);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(MyMath.Operations.Add(-1, -2), -3);
        }
    }
}
