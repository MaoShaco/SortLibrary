using System;

namespace SortLibrary.SortMechanism.Comparer
{
    class DefaultComparer<TItem> : ISpecialComparer<TItem>
    {
        public int Compare(TItem objectA, TItem objectB)
        {
            if(!(objectA is IComparable))
                throw new InvalidCastException();

            var comparableA = (IComparable) objectA;
            var comparableB = (IComparable) objectB;
            return Compare(comparableA, comparableB);
        }

        public int Compare(IComparable objectA, IComparable objectB)
        {
            return objectA.CompareTo(objectB) != 0 ? objectA.CompareTo(objectB) : 0;
        }
    }
}
