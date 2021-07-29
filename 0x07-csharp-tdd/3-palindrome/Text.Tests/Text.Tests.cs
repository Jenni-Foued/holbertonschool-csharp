using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.AreEqual(Text.Str.IsPalindrome(""), true);
        }

        [Test]
        public void IsPalindrome_StringThatContainsPunctuation_ReturnsFalse()
        {
            Assert.AreEqual(Text.Str.IsPalindrome("A man,  plan, a canal: Panama."), false);
        }

        [Test]
        public void IsPalindrome_StringThatContainsPunctuation_ReturnsTrue()
        {
            Assert.AreEqual(Text.Str.IsPalindrome("A man, a plan, a canal: Panama."), true);
        }

        [Test]
        public void IsPalindrome_String_ReturnsTrue()
        {
            Assert.AreEqual(Text.Str.IsPalindrome("AmanaplanacanalPanama"), true);
        }

        [Test]
        public void IsPalindrome_String_ReturnsFlase()
        {
            Assert.AreEqual(Text.Str.IsPalindrome("AmanaplanacanalPanam"), false);
        }
    }
}
