using System.Collections.Generic;

namespace LeetCode.P844.A2
{
    public class Solution
    {
        // Runtime: 76 ms (52.54 %)
        // Memory Usage: 22.8 MB
        public bool BackspaceCompare(string S, string T)
        {
            var currentSNode = ToLinkedList(S);
            var currentTNode = ToLinkedList(T);

            if (currentSNode == null && currentTNode == null)
            {
                return true;
            }

            if ((currentSNode == null && currentTNode != null) ||
                (currentSNode != null && currentTNode == null))
            {
                return false;
            }

            if (currentSNode.List.Count != currentTNode.List.Count)
            {
                return false;
            }

            while (currentSNode != null && currentTNode != null)
            {
                if (currentSNode.Value != currentTNode.Value)
                {
                    return false;
                }

                currentSNode = currentSNode.Previous;
                currentTNode = currentTNode.Previous;
            }

            return true;
        }

        private LinkedListNode<char> ToLinkedList(string input)
        {
            var backspaceCount = 0;
            LinkedListNode<char> currentNode = null;
            var chars = new LinkedList<char>();

            for (var i = input.Length - 1; i >= 0; --i)
            {
                if (input[i] == '#')
                {
                    ++backspaceCount;
                    continue;
                }
                else
                {
                    if (backspaceCount > 0)
                    {
                        --backspaceCount;
                        continue;
                    }
                    else
                    {
                        if (currentNode != null)
                        {
                            currentNode = chars.AddAfter(currentNode, input[i]);
                        }
                        else
                        {
                            currentNode = chars.AddFirst(input[i]);
                        }
                    }
                }
            }

            return currentNode;
        }
    }
}
