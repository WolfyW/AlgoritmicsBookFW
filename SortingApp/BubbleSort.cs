using System;

namespace AlgoritmicsBookFW.SortingApp
{
    public class BubbleArray<T> : HArray<T> where T : IComparable<T>
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
                    if (a[inner].CompareTo(a[inner + 1]) > 0)
                        Swap(inner, inner + 1);
                }

                for (inner = outerR; inner > outerL; inner--)
                {
                    if (a[inner].CompareTo(a[inner - 1]) < 0)
                        Swap(inner, inner - 1);
                }
            }
        }
    }
}
