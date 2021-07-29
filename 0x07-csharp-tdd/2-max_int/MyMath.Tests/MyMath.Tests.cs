using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Max_ListOfIntegers_ReturnsMaximumNumber()
        {
            List<int> l = new List<int>();
            l.Add(-22);
            l.Add(0);
            l.Add(-100);
            l.Add(10);
            l.Add(99);
            l.Add(-2);
            l.Add(-42);
            l.Add(-1);
            Assert.AreEqual(MyMath.Operations.Max(l),99);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> l = new List<int>();
            Assert.AreEqual(MyMath.Operations.Max(l),0);
        }
    }
}
