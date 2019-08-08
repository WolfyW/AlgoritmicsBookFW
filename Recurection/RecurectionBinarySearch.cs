using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicsBookFW.Recurection
{
    public class RecurectionBinarySearch : IRecurectionMath<int, int>
    {
        public int ResultRec { get; private set; }

        public int ResultNotRec { get; private set; }

        private int[] array;


        public RecurectionBinarySearch()
        {
            FillArr();
        }

        private void FillArr()
        {
            int size = 100000;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
        }

        public int MathWithoutRec(int serachKey)
        {
            int lowerBound = 0;
            int upperBoud = array.Length - 1;
            int current;
            while(true)
            {
                current = (lowerBound + upperBoud) / 2;
                if (array[current] == serachKey)
                {
                    ResultNotRec = current;
                    return current;
                }
                else if (lowerBound > upperBoud)
                    return -1;
                else
                {
                    if (array[current] < serachKey)
                        lowerBound = current + 1;
                    else
                        upperBoud = current - 1;
                }   
            }
        }

        public int MathWithRec(int serarchKey)
        {
            ResultRec = MathWithRec(serarchKey, 0, array.Length - 1);
            return ResultRec;
        }

        private int MathWithRec(long serarchKey, int lowerBound, int upperBound)
        {
            int current = (lowerBound + upperBound) / 2;
            if (array[current] == serarchKey)
                return current;
            else if (lowerBound > upperBound)
                return -1;
            else
            {
                if (array[current] < serarchKey)
                    return MathWithRec(serarchKey, current + 1, upperBound);
                else
                    return MathWithRec(serarchKey, lowerBound, current - 1);
            }
        }
    }
}
