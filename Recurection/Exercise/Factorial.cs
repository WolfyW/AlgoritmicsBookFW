namespace AlgoritmicsBookFW.Recurection.Exercise
{
    public class Factorial : IRecurectionMath<long, int>
    {
        public long ResultRec { get; private set; }
        public long ResultNotRec { get; private set; }
        
        public Factorial(int number)
        {
            ResultRec = MathWithRec(number);
            ResultNotRec = MathWithoutRec(number);
        }

        public long MathWithRec(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * MathWithRec(number - 1);
        }

        public long MathWithoutRec(int number)
        {
            long total = 1;
            int n = 1;
            while (number >= n)
            {
                total *= n;
                n++;
            }

            return total;
        }
    }
}
