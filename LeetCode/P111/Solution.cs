using System;

namespace LeetCode.P111
{
    public class Solution
    {
        // Runtime: 248 ms, faster than 98.55% of C# online submissions for Minimum Depth of Binary Tree.
        // Memory Usage: 51.4 MB, less than 57.76% of C# online submissions for Minimum Depth of Binary Tree.
        public int MinDepth(TreeNode? root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left == null)
            {
                return MinDepth(root.right) + 1;
            }
            else if (root.right == null)
            {
                return MinDepth(root.left) + 1;
            }
            else
            {
                return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
            }
        }
    }
}
