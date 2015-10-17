using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary.SortMechanism.SortAlgorithm
{
    public interface ISortAlgorithm<TItem>
    {
        void SortWithAlgorithm(ref List<TItem> elements, ISpecialComparer<TItem> comparer);
    }
}
