using System.Collections.Generic;

namespace AlgoritmicsBookFW.Recurection.Exercise
{
    class Backpack
    {
        private readonly List<int> _elemnts = new List<int>();

        public int Weghts { get; private set; }
        public int Count => _elemnts.Count;

        public void AddElement(int elemnt)
        {
            _elemnts.Add(elemnt);
            Weghts += elemnt;
        }
    }

    public class BackpackPickUp
    {
        // TODO доделать задачу с рюкзаком
        private int[] weight;

        public void Pick(int[] weights, int needWeight)
        {
            this.weight = weights;
            //var a = weights.SortArray();
            RecFind(0, 0, needWeight);
        }

        private void RecFind(int ptr, int ptr2, int weightNeed)
        {
            if (weight[ptr] < weightNeed)
            {
                RecFind(++ptr, ptr2, weightNeed - weight[ptr]);
            }

            if (weight[ptr] > weightNeed)
            {
                RecFind(++ptr, ptr2, weightNeed);
            }
        }
    }
}
