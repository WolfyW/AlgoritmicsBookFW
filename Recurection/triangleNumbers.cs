namespace AlgoritmicsBookFW.Recurection
{
    public class TriangleNumbers : IRecurectionMath<long, int>
    {
        public long ResultRec { get; private set; }
        public long ResultNotRec { get; private set; }

        public TriangleNumbers(int number)
        {
            ResultRec = MathWithRec(number);
            ResultNotRec = MathWithoutRec(number);
        }

        public long MathWithRec(int number)
        {
            if (number == 1)
                return 1;
            else
                return number + MathWithRec(number - 1);
        }

        public long MathWithoutRec(int number)
        {
            long total = 0;
            while (number > 0)
            {
                total += number;
                number--;
            }

            return total;
        }
    }
}
