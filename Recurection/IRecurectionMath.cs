namespace AlgoritmicsBookFW.Recurection
{
    public interface IRecurectionMath
    {
        long ResultRec { get; }
        long ResultNotRec { get; }

        long MathWithRec(int number);
        long MathWithoutRec(int number);
    }
}
