namespace LeetCode.P1427
{
    public class Solution
    {
        // Runtime: 104 ms
        // Memory Usage: 24.6 MB
        public string StringShift(string s, int[][] shift)
        {
            string prefix;
            string suffix;

            foreach (var _shift in shift)
            {
                if (_shift[0] == 0)
                {
                    prefix = s.Substring(0, _shift[1]);
                    suffix = s.Substring(_shift[1]);
                }
                else
                {
                    prefix = s.Substring(0, s.Length - _shift[1]);
                    suffix = s.Substring(s.Length - _shift[1]);
                }

                s = string.Concat(suffix, prefix);
            }

            return s;
        }
    }
}
