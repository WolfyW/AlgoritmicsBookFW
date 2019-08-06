namespace AlgoritmicsBookFW.Recurection
{
    public interface IRecurectionMath<TRes, TKey>
    {
        TRes ResultRec { get; }
        TRes ResultNotRec { get; }

        TRes MathWithRec(TKey number);
        TRes MathWithoutRec(TKey number);
    }
}
