using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{ 
        public class CacheObject
        {
            public int Value;
            public int Key;
            public CacheObject(int key, int value)
            {
                Value = value;
                Key = key;
            }
        }

        public class LRUCache
        {

            Dictionary<int, LinkedListNode<CacheObject>> map = new Dictionary<int, LinkedListNode<CacheObject>>();
            int TotalCapacity = 0;
            LinkedList<CacheObject> cache = new LinkedList<CacheObject>();

            public LRUCache(int capacity)
            {
                TotalCapacity = capacity;
            }

            public int Get(int key)
            {
                if (map.ContainsKey(key))
                {
                    var node = map[key];
                    MoveNodeFirst(node);
                    return node.Value.Value;
                }
                return -1;

            }

            public void Put(int key, int value)
            {
                Console.WriteLine($"{key}:{value}");

                if (map.ContainsKey(key))
                {
                    var object1 = new CacheObject(key, value);
                    var node = map[key];
                    node.Value = object1;
                    MoveNodeFirst(node);
                }
                else
                {
                    var object1 = new CacheObject(key, value);
                    var node = new LinkedListNode<CacheObject>(object1);
                    if (map.Count() + 1 > TotalCapacity)
                    {
                        var lastNode = cache.Last;
                        cache.RemoveLast();
                        map.Remove(lastNode.Value.Key);
                    }
                    cache.AddFirst(node);
                    map.Add(key, node);
                }
                Console.WriteLine($"{map.Count()}:{TotalCapacity}");
                foreach (var key1 in map.Keys)
                {
                    var node = map[key1].Value;
                    Console.Write($"{node.Key}|");
                }
                Console.WriteLine($"----");

            }

            private void MoveNodeFirst(LinkedListNode<CacheObject> node)
            {
                cache.Remove(node);
                cache.AddFirst(node);
            }
        }



        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */


        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */


    }
