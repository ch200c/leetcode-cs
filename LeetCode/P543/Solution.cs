using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.P543
{
    public class Solution
    {
        private int maxDiameter;
 
        public int DiameterOfBinaryTree(TreeNode root)
        {
            maxDiameter = 0;
            Traverse(root);
            return maxDiameter;
        }

        private int Traverse(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftValue = Traverse(node.left);
            var rightValue = Traverse(node.right);

            maxDiameter = Math.Max(maxDiameter, leftValue + rightValue);
            return Math.Max(leftValue, rightValue) + 1;
        }
    }
}
