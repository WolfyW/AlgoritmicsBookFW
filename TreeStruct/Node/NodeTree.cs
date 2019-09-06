namespace AlgoritmicsBookFW.TreeStruct.Node
{
    public class NodeTree<T> : INode<T, NodeTree<T>>
    {
        public T Data { get; set; }
        public NodeTree<T> Left { get; set; }
        public NodeTree<T> Right { get; set; }

        public NodeTree(T data)
        {
            Data = data;
        }
    }
}
