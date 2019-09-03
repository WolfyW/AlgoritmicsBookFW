using System;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    public class Tree<T> : BinaryTree<T> where T : IComparable<T>
    {
        public override void Insert(T item)
        {
            var newNode = new NodeTree<T>(item);

            if (RootNode == null)
                RootNode = newNode;
            else
            {
                INode<T> privious = RootNode;
                INode<T> current = RootNode;
                while (true)
                {
                    privious = current;
                    if (item.CompareTo(current.Data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            privious.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            privious.Right = newNode;
                            return;
                        }
                    }
                }

            }
        }

        public override bool Remove(T item)
        {
            bool isLeftChild;
            INode<T> parent;

            var current = FindItem(item, out parent, out isLeftChild);
            if (current == null)
                return false;

            if (current.Left == null && current.Right == null)
            {
                if (current == RootNode)
                    RootNode = null;
                else if (isLeftChild)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (current.Right == null)
            {
                if (current == RootNode)
                    RootNode = current.Left;
                else if (isLeftChild)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Left;
                }
            }
            else if (current.Left == null)
            {
                if (current == RootNode)
                    RootNode = current.Right;
                else if (isLeftChild)
                {
                    parent.Left = current.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {
                INode<T> succesor = GetSuccessor(current);
                if (current == RootNode)
                    RootNode = succesor;
                else if (isLeftChild)
                    parent.Left = succesor;
                else
                    parent.Right = succesor;

                succesor.Left = current.Left;
            }

            return true;
        }

        private INode<T> GetSuccessor(INode<T> delNode)
        {
            INode<T> sucParent = delNode;
            INode<T> suc = delNode;
            INode<T> currnet = delNode.Right;

            while (currnet != null)
            {
                sucParent = suc;
                suc = currnet;
                currnet = currnet.Left;
            }

            if (suc != delNode.Right)
            {
                sucParent.Left = suc.Right;
                suc.Right = delNode.Right;
            }

            return suc;
        }

        private INode<T> FindItem(T item, out INode<T> parent, out bool isLeftChild)
        {
            INode<T> current = RootNode;
            parent = RootNode;
            isLeftChild = true;

            while (current.Data.CompareTo(item) != 0)
            {
                parent = current;
                if (item.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }

                if (current == null)
                    return null;
            }
            return current;
        }

        private INode<T> FindItem(T item, out INode<T> parent)
        {
            bool isLeft = true;
            var temp = FindItem(item, out parent, out isLeft);
            return temp;
        }
    }
}
