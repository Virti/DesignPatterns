namespace OpenClosedPrinciple
{
    public abstract class Policy<T> : IPolicy<T>
    {
        public abstract bool IsTestPassing(T subject);
    }
}