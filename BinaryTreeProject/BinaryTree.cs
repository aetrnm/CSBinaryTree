using System;
using System.Collections;

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
            return _root?.Contains(value) ?? false;
        }

        public override string ToString()
        {
            return string.Join(" ", this);
        }

        public IEnumerator GetEnumerator()
        {
            if (_root is null)
            {
                throw new Exception("Tree is empty.");
            }
            return _root.GetEnumerator();
        }
    }
}