namespace OpenClosedPrinciple
{
    public interface IPolicy<T>
    {
        bool IsTestPassing(T subject);
    }
}