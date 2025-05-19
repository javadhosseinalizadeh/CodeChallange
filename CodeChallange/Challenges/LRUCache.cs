using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallange.Challenges
{
    public class LRUCache<K, V>
    {
        /*
        ساخت یک کش که همیشه فقط
        N
        آیتم آخر استفاده شده رو نگه می‌داره
        و اگر پر شد، آیتمی که قدیمی‌تر استفاده شده رو حذف می‌کنه.
        thread-safe هم هست
        */

        private readonly int _capacity;
        private readonly LinkedList<CacheItem> _list = new();
        private readonly Dictionary<K, LinkedListNode<CacheItem>> _map = new();
        private readonly object _lock = new();

        public LRUCache(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            _capacity = capacity;
        }

        public V Get(K key)
        {
            lock (_lock)
            {
                if (!_map.TryGetValue(key, out var node))
                    throw new KeyNotFoundException("Key not found.");

                _list.Remove(node);
                _list.AddFirst(node);
                return node.Value.Value;
            }
        }

        public void Put(K key, V value)
        {
            lock (_lock)
            {
                if (_map.TryGetValue(key, out var existingNode))
                {
                    existingNode.Value.Value = value;
                    _list.Remove(existingNode);
                    _list.AddFirst(existingNode);
                    return;
                }

                if (_map.Count >= _capacity)
                {
                    var lruNode = _list.Last!;
                    _map.Remove(lruNode.Value.Key);
                    _list.RemoveLast();
                }

                var newItem = new CacheItem { Key = key, Value = value };
                var node = new LinkedListNode<CacheItem>(newItem);
                _list.AddFirst(node);
                _map[key] = node;
            }
        }

        public void PrintCache()
        {
            Console.WriteLine("Cache (Most recent → Least recent):");
            foreach (var item in _list)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }



        private class CacheItem
        {
            public K Key { get; set; } = default!;
            public V Value { get; set; } = default!;
        }
    }
}
