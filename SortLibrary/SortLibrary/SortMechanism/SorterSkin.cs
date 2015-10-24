using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm;

namespace SortLibrary.SortMechanism
{
    abstract class SorterSkin<TItem>
    {
        public void Sort(ref List<TItem> elements, AlgorithmType algorithm)
        {
            Sort(ref elements, new DefaultComparer<TItem>(), algorithm);
        }

        public abstract void Sort(ref List<TItem> elements, ISpecialComparer<TItem> comparer, AlgorithmType algorithm);
    }
}
