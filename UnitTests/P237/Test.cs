using Xunit;

namespace UnitTests.P237
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P237.Solution();

            var head = new LeetCode.P237.ListNode(4);
            head.next = new LeetCode.P237.ListNode(5);
            head.next.next = new LeetCode.P237.ListNode(1);
            head.next.next.next = new LeetCode.P237.ListNode(9);
            solution.DeleteNode(head.next);

            Assert.Equal(4, head.val);
            Assert.Equal(1, head.next.val);
            Assert.Equal(9, head.next.next.val);
        }
    }
}
