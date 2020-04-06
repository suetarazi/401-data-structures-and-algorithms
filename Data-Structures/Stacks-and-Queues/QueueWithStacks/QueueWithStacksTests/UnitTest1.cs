using System;
using Xunit;
using QueueWithStacks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueValueOntoExistingStack()
        {
            int Value = 5; 
            Pseudoqueue.Enqueue(Value);
            
        }
    }
}
