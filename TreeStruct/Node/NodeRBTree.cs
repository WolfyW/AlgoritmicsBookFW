namespace AlgoritmicsBookFW.TreeStruct.Node
{
    public class NodeRbTree<TData> : INode<TData, NodeRbTree<TData>>
    {
        public bool IsBlack { get; set; }

        public TData Data { get; set; }
        public NodeRbTree<TData> Left { get; set; }
        public NodeRbTree<TData> Right { get; set; }
        public NodeRbTree<TData> Parent { get; set; }

        public NodeRbTree(TData data)
        { }
    }
}
