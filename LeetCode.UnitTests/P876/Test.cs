using Xunit;

namespace LeetCode.UnitTests.P876
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P876.Solution();
            // TODO
            var node = new LeetCode.P876.ListNode(1);
            node.next = new LeetCode.P876.ListNode(2);
            node.next.next = new LeetCode.P876.ListNode(3);
            node.next.next.next = new LeetCode.P876.ListNode(4);
            node.next.next.next.next = new LeetCode.P876.ListNode(5);
            var result = solution.MiddleNode(node);
            Assert.Equal(3, result.val);
        }
    }
}
