using Xunit;

namespace UnitTests.P155
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var minStack = new LeetCode.P155.MinStack();
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(3);
            minStack.Push(4);
            Assert.Equal(4, minStack.Top());
        }

        [Fact]
        public void Test2()
        {
            var minStack = new LeetCode.P155.MinStack();
            minStack.Push(1);
            minStack.Push(2);
            minStack.Push(3);
            minStack.Push(4);
            minStack.Pop();
            Assert.Equal(3, minStack.Top());
        }

        [Fact]
        public void Test3()
        {
            var minStack = new LeetCode.P155.MinStack();
            minStack.Push(1);
            minStack.Push(2);
            minStack.Pop();
            minStack.Push(3);
            minStack.Pop();
            minStack.Push(4);
            minStack.Push(-1);
            Assert.Equal(-1, minStack.GetMin());
        }
    }
}
