namespace LeetCode.P201
{
    public class Solution
    {
		// Runtime: 56 ms (65.91 %)
		// Memory Usage: 15.6 MB
		public int RangeBitwiseAnd(int m, int n)
        {
			var count = 0;
			while (m != n)
			{
				m >>= 1;
				n >>= 1;
				++count;
			}

			return n << count;
		}
    }
}
