namespace LeetCode.P200.A2
{
    class Cell
    {
        public Cell up;
        public Cell left;
        public Cell right;
        public Cell down;
        public int islandIndex;
        public Cell()
        {
            islandIndex = -1;
        }
    }
}
