using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            Assert.AreEqual(Text.Str.UniqueChar(""), -1);
        }

        [Test]
        public void UniqueChar_String_ReturnsIndex()
        {
            Assert.AreEqual(Text.Str.UniqueChar("abcd"), 0);
        }

        [Test]
        public void UniqueChar_String_ReturnsNegativeOne()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aabbccdd"), -1);
        }

        [Test]
        public void UniqueChar_Null_ReturnsNegativeOne()
        {
            Assert.AreEqual(Text.Str.UniqueChar(null), -1);
        }
        [Test]
        public void UniqueChar_InTheEnd()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aabbccd"), 6);
        }

        [Test]
        public void UniqueChar_InTheMiddle()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aabbcddee"), 4);
        }
    }
}