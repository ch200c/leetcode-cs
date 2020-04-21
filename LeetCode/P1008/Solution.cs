namespace LeetCode.P1008
{
    public class Solution
    {
        private int[] _preorder;
        private int _i;

        // Runtime: 96 ms (40.60 %)
        // Memory Usage: 24.4 MB
        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }

            _preorder = preorder;
            _i = 0;

            return Traverse(int.MaxValue);
        }

        private TreeNode Traverse(int bound)
        {
            if (_i == _preorder.Length || _preorder[_i] > bound)
            {
                return null;
            }

            var rootNode = new TreeNode(_preorder[_i]);
            ++_i;

            rootNode.left = Traverse(rootNode.val);
            rootNode.right = Traverse(bound);
            return rootNode;
        }
    }
}
