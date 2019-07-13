namespace AlgoritmicsBookFW.SortingApp
{
    public class SelectedArray : HArray<long>
    {
        public SelectedArray(int maxElements) : base(maxElements)
        { }

        public override void Sort()
        {
            int outer, inner, min;
            for (outer = 0; outer < nElements - 1; outer++)
            {
                min = outer;
                for (inner = outer + 1; inner < nElements; inner++)
                {
                    if (a[inner] < a[min])
                        min = inner;
                }
                Swap(outer, min);
            }
        }
    }
}
