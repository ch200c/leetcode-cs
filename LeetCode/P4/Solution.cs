namespace LeetCode.P4;

public class Solution
{
    // Runtime: 121 ms (71.28%)
    // Memory Usage: 39.6 MB (61.06%)
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var orderedNumbers = new int[nums1.Length + nums2.Length];

        var nums1Index = 0;
        var nums2Index = 0;
        var orderedNumbersIndex = 0;

        while (nums1Index < nums1.Length || nums2Index < nums2.Length)
        {
            var num1 = nums1Index < nums1.Length ? nums1[nums1Index] : int.MaxValue;
            var num2 = nums2Index < nums2.Length ? nums2[nums2Index] : int.MaxValue;

            if (num1 < num2)
            {
                orderedNumbers[orderedNumbersIndex++] = num1;
                nums1Index++;
            }
            else
            {
                orderedNumbers[orderedNumbersIndex++] = num2;
                nums2Index++;
            }
        }

        if (orderedNumbers.Length % 2 == 0)
        {
            var index1 = (orderedNumbers.Length / 2) - 1;
            var index2 = orderedNumbers.Length / 2;
            return (orderedNumbers[index1] + orderedNumbers[index2]) / 2.0;
        }
        else
        {
            var index = orderedNumbers.Length / 2;
            return orderedNumbers[index];
        }
    }
}