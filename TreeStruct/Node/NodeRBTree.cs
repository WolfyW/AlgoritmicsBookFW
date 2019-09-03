namespace AlgoritmicsBookFW.TreeStruct.Node
{
    public class NodeRBTree<T> : INode<T>
    {
        public bool IsBlack { get; set; }

        public T Data { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public NodeRBTree(T data)
        { }
    }
}
