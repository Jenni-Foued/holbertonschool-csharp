using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Camelcase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(Text.Str.CamelCase(""), 0);
        }

        [Test]
        public void Camelcase_OneWordString_ReturnsOne()
        {
            Assert.AreEqual(Text.Str.CamelCase("one"), 1);
        }

        [Test]
        public void Camelcase_String_ReturnsCount()
        {
            Assert.AreEqual(Text.Str.CamelCase("lorem Ipsum Dolor Sit Amet"), 5);
        }

        [Test]
        public void Camelcase_TwoWordString_ReturnsOne()
        {
            Assert.AreEqual(Text.Str.CamelCase("one Two"), 2);
        }
    }
}