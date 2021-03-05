using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTreeProject
{
    public class BinaryTree<T> : IEnumerable where T : IComparable<T>
    {
        private Cell<T> _root;
        
        public void Add(T value)
        {
            if (_root is null)
            {
                _root = new Cell<T>(value);
            }
            else
            {
                _root.Add(value);
            }
        }

        public bool Contains(T value)
        {
            return _root.Contains(value);
        }

        public override string ToString()
        {
            List<T> tree = new List<T>();
            foreach (T x in this)
            {
                tree.Add(x);
            }
            return string.Join(" ", tree);
        }

        public IEnumerator GetEnumerator()
        {
            return _root.GetEnumerator();
        }
    }
}