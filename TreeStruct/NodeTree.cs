namespace AlgoritmicsBookFW.TreeStruct
{
    class NodeTree<T>
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
