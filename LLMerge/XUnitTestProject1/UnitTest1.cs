using System;
using Xunit;
using LLMerge;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //test to see whether two linked lists of equal length merged successfully
        [Fact]
        public void TestMergeOfLinkedListsOfEqualLengths()
        {
            Linklist List1 = new Linklist();
            List1.Insert(1);
            List1.Insert(3);
            List1.Insert(2);

            Linklist List2 = new Linklist();
            List2.Insert(5);
            List2.Insert(9);
            List2.Insert(4);

            Linklist MergedList = new Linklist();
            MergedList.Insert(1);
            MergedList.Insert(5);
            MergedList.Insert(3);
            MergedList.Insert(9);
            MergedList.Insert(2);
            MergedList.Insert(4);

            Assert.Equal(MergedList);
        }
    
        //Test to see if two linked lists of different lengths merged successfully
        public void TestMergeOfLinkedListsOfUnequalLengths()
        {
            Linklist List1 = new Linklist();
            List1.Insert(1);
            List1.Insert(3);
            

            Linklist List2 = new Linklist();
            List2.Insert(5);
            List2.Insert(9);
            List2.Insert(4);

            Linklist MergedList = new Linklist();
            MergedList.Insert(1);
            MergedList.Insert(5);
            MergedList.Insert(3);
            MergedList.Insert(9);
            MergedList.Insert(4);

            Assert.Equal(MergedList);
        }
    
    }
}
