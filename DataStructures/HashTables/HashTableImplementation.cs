using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableImplementation
{
    class MyNode
    {
        public string key { get; set; }
        public int value { get; set; }

        public MyNode(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class HashTable
    {
        private class MyNodes : List<MyNode> { }
        private int length;
        private MyNodes[] data;

        public HashTable(int size)
        {
            this.length = size;
            this.data = new MyNodes[size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }

            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            if (this.data[index] == null)
            {
                this.data[index] = new MyNodes();
            }
            this.data[index].Add(new MyNode(key, value));
        }

        public int Get(string key) 
        {
            int index = Hash(key);
            if (this.data[index] == null)
            {
                return 0;
            }

            foreach (var node in this.data[index])
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
            }

            return 0;
        }

        public List<string> Keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != null)
                {
                    for (int j = 0; j < length; j++)
                    {
                        result.Add(this.data[i][j].key);
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            HashTable h = new HashTable(2);
            h.Set("grapes", 1000);
            h.Set("apples", 54);
            Console.Write(h.Get("apples"));
            h.Keys();

            Console.Read();
        }
    }
}
