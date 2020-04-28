using RepeatedWord;
using System;
using System.Collections;
using Xunit;
using RepeatedWord.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// unit test to confirm method is working
        /// </summary>
        [Fact]
        public static void ConfirmRepeatedWords()
        {
            Repeatedword rw = new Repeatedword();
            Hashtable hashtable = new Hashtable();
            string words = "She sells sea shells by the sea shore";
            string actual = rw.FindRepeatedWord(words);
            string expected = "sea";
            Assert.Equal(expected, actual);

        }
    }
}
