using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public static class LruCacheDemo
    {
        public static void Run()
        {
            var cache = new LRUCache<int, string>(3);

            cache.Put(1, "A");
            cache.Put(2, "B");
            cache.Put(3, "C");
            cache.PrintCache();

            Console.WriteLine("\nAccessing key 2...");
            var val = cache.Get(2);
            Console.WriteLine($"Value of key 2: {val}");

            Console.WriteLine("Inserting key 4...");
            cache.Put(4, "D");

            cache.PrintCache();
        }
    }
}
