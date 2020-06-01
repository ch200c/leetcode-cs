namespace LeetCode.P226
{
    public class Solution
    {
        private void Invert(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            var leftNode = root.left;
            root.left = root.right;
            root.right = leftNode;
            Invert(root.left);
            Invert(root.right);
        }

        // Runtime: 92 ms (78.91 %)
        // Memory Usage: 24.2 MB
        public TreeNode InvertTree(TreeNode root)
        {
            Invert(root);
            return root;
        }
    }
}
