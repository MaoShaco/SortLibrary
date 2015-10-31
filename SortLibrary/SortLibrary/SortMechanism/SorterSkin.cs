using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary.SortMechanism
{
    internal abstract class SorterSkin<TItem>
    {
        public void Sort(List<TItem> elements)
        {
            Sort(elements, new DefaultComparer<TItem>());
        }

        public abstract void Sort(List<TItem> elements, ISpecialComparer<TItem> comparer);
    }
}
