using LeetCode.P111;
using Xunit;

namespace UnitTests.P111
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var solution = new Solution();
            var answer = solution.MinDepth(root);

            Assert.Equal(2, answer);
        }
    }
}
