using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm;

namespace SortLibrary.SortMechanism
{
    class DefaultSorter<TItem> : Sorter<TItem>
    {
        public override void Sort(ref List<TItem> elements, ISpecialComparer<TItem> comparer, AlgorithmType algorithm)
        {
            //var a = new ShellAlgorithm<TItem>();
            //var a = new BubbleAlgorithm<TItem>();
            //var a = new TreeAlgorithm<TItem>();
            var a = AlgorithmSwitch<TItem>.SwitchAlgorithm(algorithm);
            a.SortWithAlgorithm(ref elements, comparer);
        }
    }
}
