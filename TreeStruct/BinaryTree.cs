using System;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    public abstract class BinaryTree<TData, TNode> : TreeAbstract<TData, TNode> where TData : IComparable<TData>
                                                                  where TNode : INode<TData, TNode>
    {
        public override bool Find(TData item)
        {
            TNode current = RootNode;
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

        public TData Max()
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

        public TData Min()
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