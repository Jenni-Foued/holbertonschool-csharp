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
        public void UniqueChar_FirstChar()
        {
            Assert.AreEqual(Text.Str.UniqueChar("abcd"), 0);
        }

        [Test]
        public void UniqueChar_String_ReturnsNegativeOne()
        {
            Assert.AreEqual(Text.Str.UniqueChar("aabbccdd"), -1);
        }

        [Test]
        public void UniqueChar_InThemiddle()
        {
            Assert.AreEqual(4, Text.Str.UniqueChar("aabbeccdd"));
        }

        [Test]
        public void UniqueChar_LastChar()
        {
            Assert.AreEqual(7, Text.Str.UniqueChar("aabbcccd"));
        }        
    }
}
