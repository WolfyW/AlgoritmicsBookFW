namespace AlgoritmicsBookFW.Recurection
{
    public class TriangleNumbers
    {
        public long NumberRec { get; private set; }
        public long NumberNotRec { get; private set; }
        public TriangleNumbers(int number)
        {
            NumberRec = TriangleRecur(number);
            NumberNotRec = TriangleNotRecur(number);
        }

        public long TriangleRecur(int number)
        {
            if (number == 1)
                return 1;
            else
                return number + TriangleRecur(number - 1);
        }

        public long TriangleNotRecur(int number)
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
