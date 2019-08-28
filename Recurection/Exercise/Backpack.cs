using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AlgoritmicsBookFW.SortingApp;

namespace AlgoritmicsBookFW.Recurection.Exesizes
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
        private int[] weight;

        public void Pick(int[] weights, int needWeight)
        {
            this.weight = weights;
            //var a = weights.SortArray();
            RecFind(0, 0, needWeight);
        }

        public void RecFind(int ptr, int ptr2, int weightNeed)
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
