using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Add_Positive()
        {
            Assert.AreEqual(MyMath.Operations.Add(1, 2), 3);
        }

        [Test]
        public void Add_OneNegative()
        {
            Assert.AreEqual(MyMath.Operations.Add(1, -2), -1);
        }

        [Test]
        public void Add_Negative()
        {
            Assert.AreEqual(MyMath.Operations.Add(-1, -2), -3);
        }
    }
}
