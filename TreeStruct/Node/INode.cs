namespace AlgoritmicsBookFW.TreeStruct.Node
{
    public interface INode<T, TV> where TV : INode<T, TV>
    {
        T Data { get; set; }
        TV Left { get; set; }
        TV Right { get; set; }
    }
}
