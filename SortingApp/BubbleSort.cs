namespace AlgoritmicsBookFW.SortingApp
{
    public class BubbleArray : HArray<long>
    {
        public BubbleArray(int maxElement) : base(maxElement)
        { }

        public override void Sort()
        {
            int outerR, outerL, inner;
            for (outerR = nElements - 1, outerL = 0; outerR > 1; outerR--, outerL++)
            {
                for (inner = 0; inner < outerR; inner++)
                {
                    if (a[inner] > a[inner + 1])
                        Swap(inner, inner + 1);
                }

                for (inner = outerR; inner > outerL; inner--)
                {
                    if (a[inner] < a[inner - 1])
                        Swap(inner, inner - 1);
                }
            }
        }
    }
}
