using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.P1046
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            var result = -1;
            while (result == -1)
            {
                Array.Sort(stones);

                if (stones.Length == 1)
                {
                    result = stones[0];
                    break;
                }

                var stone1 = stones[^1];
                var stone2 = stones[^2];

                if (stone1 == 0)
                {
                    result = stone2;
                    break;
                }

                if (stone2 == 0)
                {
                    result = stone1;
                    break;
                }

                stones[^1] = 0;
                stones[^2] = 0;

                if (stone1 != stone2)
                {
                    stones[^2] = Math.Max(stone1, stone2) - Math.Min(stone1, stone2);
                }
            }

            return result;
        }
    }
}
