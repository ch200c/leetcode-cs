using Xunit;

namespace LeetCode.UnitTests.P543
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var solution = new LeetCode.P543.Solution();
            
            // TODO
            var tree = new LeetCode.P543.TreeNode(1);
            tree.left = new LeetCode.P543.TreeNode(2);
            tree.right = new LeetCode.P543.TreeNode(3);
            tree.left.left = new LeetCode.P543.TreeNode(4);
            tree.left.right = new LeetCode.P543.TreeNode(5);
            var result = solution.DiameterOfBinaryTree(tree);
            Assert.Equal(3, result);
        }
    }
}
