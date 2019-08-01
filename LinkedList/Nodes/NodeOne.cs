namespace AlgoritmicsBookFW.LinkedList.Nodes
{
    public class NodeOne<T>
    {
        public T Data { get; set; }
        public NodeOne<T> Next { get; set; }

        public NodeOne(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
