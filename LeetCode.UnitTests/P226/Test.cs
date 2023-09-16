using Xunit;

namespace LeetCode.UnitTests.P226
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P226.Solution();

            var root = new LeetCode.P226.TreeNode(4);
            root.left = new LeetCode.P226.TreeNode(2);
            root.left.left = new LeetCode.P226.TreeNode(1);
            root.left.right = new LeetCode.P226.TreeNode(3);
            root.right = new LeetCode.P226.TreeNode(7);
            root.right.left = new LeetCode.P226.TreeNode(6);
            root.right.right = new LeetCode.P226.TreeNode(9);

            var result = solution.InvertTree(root);
            Assert.Equal(4, result.val);
            Assert.Equal(7, result.left.val);
            Assert.Equal(9, result.left.left.val);
            Assert.Equal(6, result.left.right.val);
            Assert.Equal(2, result.right.val);
            Assert.Equal(3, result.right.left.val);
            Assert.Equal(1, result.right.right.val);

        }

        [Fact]
        public void Test2()
        {
            var solution = new LeetCode.P226.Solution();

            var root = new LeetCode.P226.TreeNode(1);
            root.left = new LeetCode.P226.TreeNode(2);

            var result = solution.InvertTree(root);
            Assert.Equal(1, result.val);
            Assert.Null(result.left);
            Assert.Equal(2, result.right.val);
        }
    }
}
