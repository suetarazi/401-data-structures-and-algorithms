using System;
using Xunit;
using Stacks_and_Queues.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// test to see if successful push onto stack
        /// </summary>
        [Fact]
        public void TestPushOntoStack()
        {
            Stack stack = new Stack();
            int value = 1;
            int actual = stack.Push(value);
            int expected = value;
            Assert.Equal(actual, expected);

        }

        /// <summary>
        /// test to see if multiple pushes onto stack
        /// </summary>
        [Fact]
        public void TestCanSuccessfullyPushMultipleValuesOntoStack()
        {
            Stack stack = new Stack();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            stack.Push(value1);
            stack.Push(value2);
            stack.Push(value3);
            int[] actual = [1, 2, 3];
            int[] expected = [value1, value2, value3];
            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// test to see if pop off stack and return value of popped node
        /// </summary>
        [Fact]
        public void TestCanPopOffTheStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            int actual = stack.Pop();
            int expected = 1;
            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// test to see if stack is empty after multiple pops
        /// </summary>
        [Fact]
        public void CanSuccessfullyEmptyStackAfterMultiplePops()
        {
            Stack stack = new Stack();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            stack.Push(value1);
            stack.Push(value2);
            stack.Push(value3);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Assert.IsType(NullReferenceException);
        }

        /// <summary>
        /// test to peek at top of stack
        /// </summary>
        [Fact]
        public void CanSuccessfullyPeekTheNextItemOnTheStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            int actual = stack.Peek();
            int expected = 1;
            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// test to successfully instatiate empty stack
        /// </summary>
        [Fact]
        public void CanSuccessfullyInstantiateEmptyStack()
        {
            Stack stack = new Stack();
        }

        /// <summary>
        /// exception test to see if exception is returned if we try and pop an empty stack
        /// </summary>
        [Fact]
        public void CallingPopOnEmptyStackRaisesException()
        {
            Stack stack = new Stack();
            stack.Pop();
            Assert.IsType(NullReferenceException);
        }    
    
    
    
    }

}
