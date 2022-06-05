namespace DesignPatterns._05___Iterator_Pattern
{
    public interface Iterator<T>
    {
        bool hasNext();
        T current();
        void next();
    }
}
