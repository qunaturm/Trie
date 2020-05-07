using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    class Node<T>
    {
        public string Key { get; private set; }
        public T Data { get; private set; }
        public bool Flag { get; set; }
        public Dictionary<string, Node<T>> SubNodes { get; set; }
        
    }
}
