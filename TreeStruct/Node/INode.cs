namespace AlgoritmicsBookFW.TreeStruct.Node
{
    public interface INode<T>
    {
        T Data { get; set; }
        INode<T> Left { get; set; }
        INode<T> Right { get; set; }
    }
}
