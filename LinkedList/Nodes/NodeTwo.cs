namespace AlgoritmicsBookFW.LinkedList.Nodes
{
    public class NodeTwo<T>
    {
        public T Data { get; set; }

        public NodeTwo<T> Next { get; set; }
        public NodeTwo<T> Previus { get; set; }

        public NodeTwo(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
