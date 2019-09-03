using System;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    public abstract class BinaryTree<T> : TreeAbstract<T> where T : IComparable<T>
    {
        public override bool Find(T item)
        {
            INode<T> current = RootNode;
            while (current.Data.CompareTo(item) != 0)
            {
                if (item.CompareTo(current.Data) < 0)
                    current = current.Left;
                else
                    current = current.Right;

                if (current == null)
                    return false;
            }
            return true;
        }

        public T Max()
        {
            var current = RootNode;
            var previous = current;
            while (current != null)
            {
                previous = current;
                current = current.Right;
            }

            return previous.Data;
        }

        public T Min()
        {
            var current = RootNode;
            var previous = current;
            while (current != null)
            {
                previous = current;
                current = current.Left;
            }

            return previous.Data;
        }
    }
}