using Hashtables;
using Hashtables.Classes;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestInstantiateClass()
        {
            hashtable<object> testTable = new hashtable<object>(50);
            Assert.Equal(50, testTable.Arr.Length);
        }

        [Fact]
        public void TestHashWithKey()
        {
            string key = "cat";
            hashtable<object> testTable = new hashtable<object>(2000);
            int actual = testTable.Hash(key);
            Assert.Equal(433422, actual);    
        }
    }
}
