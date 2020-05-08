using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    class Node<T>
    {
        public char Symbol { get; private set; }
        public T Data { get; private set; }
        public bool Flag { get; set; }
        public string Prefix { get; set; } 
        public Dictionary<string, Node<T>> SubNodes { get; set; }

        public Node(T data) //ctor
        {
            if (data != null)
            {
                Data = data;
                //Flag = false;
                
            }
        }

        public Node(string key, T data)
        {
            Data = data;
            //Flag = false;
        }

        public override string ToString() //?????????
        {
            return Data.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.Equals(item);
            }

            else return false;
        }

    }
}
