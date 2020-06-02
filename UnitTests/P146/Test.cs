using Xunit;

namespace UnitTests.P146
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
            var cache = new LeetCode.P146.LRUCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.Equal(1, cache.Get(1));
            cache.Put(3, 3);
            Assert.Equal(-1, cache.Get(2));
            cache.Put(4, 4);
            Assert.Equal(-1, cache.Get(1));
            Assert.Equal(3, cache.Get(3));
            Assert.Equal(4, cache.Get(4));
        }

        [Fact]
        public void Test2()
        {
            var cache = new LeetCode.P146.LRUCache(2);

            cache.Put(2, 1);
            cache.Put(2, 2);
            Assert.Equal(2, cache.Get(2));
            cache.Put(1, 1);
            cache.Put(4, 1);
            Assert.Equal(-1, cache.Get(2));
        }

        [Fact]
        public void Test3()
        {
            var cache = new LeetCode.P146.LRUCache(2);

            Assert.Equal(-1, cache.Get(2));
            cache.Put(2, 6);
            Assert.Equal(-1, cache.Get(1));
            cache.Put(1, 5);
            cache.Put(1, 2);
            Assert.Equal(2, cache.Get(1));
            Assert.Equal(6, cache.Get(2));
        }
    }
}
