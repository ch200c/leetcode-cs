namespace LeetCode.P237
{
    public class Solution
    {
        // Runtime: 96 ms (66.20 %)
        // Memory Usage: 24.8 MB
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
