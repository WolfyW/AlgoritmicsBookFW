using System;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    public class Tree<TData> : BinaryTree<TData, NodeTree<TData>> where TData : IComparable<TData>
    {
        public override void Insert(TData item)
        {
            var newNode = new NodeTree<TData>(item);

            if (RootNode == null)
                RootNode = newNode;
            else
            {
                NodeTree<TData> privious = RootNode;
                NodeTree<TData> current = RootNode;
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

        public override bool Remove(TData item)
        {
            bool isLeftChild;
            NodeTree<TData> parent;

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
                NodeTree<TData> succesor = GetSuccessor(current);
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

        private NodeTree<TData> GetSuccessor(NodeTree<TData> delNode)
        {
            NodeTree<TData> sucParent = delNode;
            NodeTree<TData> suc = delNode;
            NodeTree<TData> currnet = delNode.Right;

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

        private NodeTree<TData> FindItem(TData item, out NodeTree<TData> parent, out bool isLeftChild)
        {
            NodeTree<TData> current = RootNode;
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

        private NodeTree<TData> FindItem(TData item, out NodeTree<TData> parent)
        {
            bool isLeft = true;
            var temp = FindItem(item, out parent, out isLeft);
            return temp;
        }
    }
}
