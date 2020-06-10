using System;
using Xunit;
using ArraySum;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PositiveTestCase()
        {
            int[] watch = new int[] { 1, 2, 3, 4, 5 };
            int interval = 3;
            int[] actual = Program.TVWatch2(watch, interval);
            int[] expected = new int[] { 6, 9, 12 };
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void NegativeTestCase()
        {
            int[] watch = new int[] { 1, 2, 3, 4, 5 };
            int interval = 3;
            int[] output = Program.TVWatch2(watch, interval);
            //int notTrue =  
            //Assert.False(notTrue);
        }
    }
}
