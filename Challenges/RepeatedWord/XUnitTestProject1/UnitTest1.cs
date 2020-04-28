using RepeatedWord;
using System;
using System.Collections;
using Xunit;
using RepeatedWord.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public static void ConfirmRepeatedWords()
        {
            Hashtable hashtable = new Hashtable();
            string words = "She sells sea shells by the sea shore";
            string actual = Repeatedword.RepeatedWords(words);
            string expected = "sea";
            Assert.Equal(expected, actual);

        }
    }
}
