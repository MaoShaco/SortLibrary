using System;
using System.Collections.Generic;

namespace SortLibrary.SortMechanism.Comparer
{
    public interface ISpecialComparer<in TItem> : IComparer<TItem>
    {
        new int Compare(TItem objectA, TItem objectB);
    }
}
