using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Trie
{
    class Trie<T>
    {
        private Node<T> Root { get; set; }
        public int Count { get; set; }

        public Trie(T data)
        {
            if (data != null)
            {
                Root = new Node<T>(" ", data);
                Count = 1;
            } 
        }
        public void Add(string key, T data)
        {
            var current = Root;
            foreach(var sym in key)
            {
                if(current.Data != null)
                {
                    Add(key, current.Data);
                }
            }
        }

        public void Remove(T data)
        {

        }

        public T Search(string key)
        {

        }

    }
}
