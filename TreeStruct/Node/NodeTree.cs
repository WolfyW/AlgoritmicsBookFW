namespace AlgoritmicsBookFW.TreeStruct.Node
{
    public class NodeTree<T> : INode<T>
    {
        public T Data { get; set; }
        public INode<T> Left { get; set; }
        public INode<T> Right { get; set; }

        public NodeTree(T data)
        {
            Data = data;
        }
    }
}
