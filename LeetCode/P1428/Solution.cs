using System.Collections.Generic;
using System.Linq;

namespace LeetCode.P1428
{
    public class Solution
    {
        // Runtime: 100 ms
        // Memory Usage: 27.1 MB
        public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var oneIndices = new SortedSet<int>();
            var dimensions = binaryMatrix.Dimensions();

            for (var row = 0; row < dimensions[0]; ++row)
            {
                var startIndex = 0;
                var endIndex = dimensions[1] - 1;

                while (startIndex <= endIndex)
                {
                    var index = startIndex + (endIndex - startIndex) / 2;

                    if (binaryMatrix.Get(row, index) == 0)
                    {
                        startIndex = index + 1;
                    }
                    else
                    {
                        oneIndices.Add(index);
                        endIndex = index - 1;
                    }
                }
            }

            return oneIndices.Count == 0 ? -1 : oneIndices.First();
        }
    }
}
