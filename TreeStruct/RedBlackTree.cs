using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using AlgoritmicsBookFW.TreeStruct.Node;

namespace AlgoritmicsBookFW.TreeStruct
{
    class RedBlackTree<T> : BinaryTree<T, NodeRbTree<T>> where T : IComparable<T>
    {
        public override void Insert(T item)
        {
            NodeRbTree<T> newNode = new NodeRbTree<T>(item)
            {
                IsBlack = false
            };

            if (RootNode == null)
            {
                RootNode = newNode;
                RootNode.IsBlack = true;
                return;
            }

            NodeRbTree<T> privious = RootNode;
            NodeRbTree<T> current = RootNode;
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

        private void RigthTurn(NodeRbTree<T> G)
        {
            var P = G.Left;

            P.Parent = G.Parent;
            if (G == RootNode)
            {
                RootNode = P;
            }
            if (G.Parent.Left == G)
                G.Parent.Left = P;
            else
                G.Parent.Right = P;

            G.Left = P.Right;
            if (P.Right != null)
                P.Right.Parent = G;

            G.Parent = P;
            P.Right = G;
        }

        private void LeftTurn(NodeRbTree<T> G)
        {
            var P = G.Right;
            P.Parent = G.Parent;
            if (G == RootNode)
            {
                RootNode = P;
            }
            if (G.Parent.Left == G)
                G.Parent.Left = P;
            else
                G.Parent.Right = P;

            G.Right = P.Left;
            if (P.Left != null)
                P.Left.Parent = G;

            G.Parent = P;
            P.Left = G;
        }

        public override bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
