namespace LeetCode.P33
{
    public class Solution
    {
        // Runtime: 96 ms (46.09 %)
        // Memory Usage: 24.8 MB
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }

            int startIndex = 0;
            int endIndex = nums.Length - 1;

            while (startIndex <= endIndex)
            {
                int middleIndex = startIndex + (endIndex - startIndex) / 2;

                if (nums[middleIndex] == target)
                {
                    return middleIndex;
                }
                    
                if (middleIndex - 1 >= startIndex && nums[startIndex] <= nums[middleIndex - 1])
                {
                    if (nums[startIndex] <= target && target <= nums[middleIndex - 1])
                    {
                        endIndex = middleIndex - 1;
                    }
                    else
                    {
                        startIndex = middleIndex + 1;
                    }  
                }
                else if (middleIndex + 1 <= endIndex && nums[middleIndex + 1] <= nums[endIndex])
                {
                    if (nums[middleIndex + 1] <= target && target <= nums[endIndex])
                    {
                        startIndex = middleIndex + 1;
                    }
                    else
                    {
                        endIndex = middleIndex - 1;
                    }
                }
                else
                {
                    break;
                }
            }

            return -1;
        }
    }
}
