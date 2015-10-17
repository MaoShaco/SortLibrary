using System.Collections.Generic;
using SortLibrary.SortMechanism.SortAlgorithm.SwapMechanism;

namespace SortLibrary.SortMechanism.SortAlgorithm
{
    internal class BubbleAlgorithm<TItem> : ISortAlgorithm<TItem>
    {
        public void SortWithAlgorithm(ref List<TItem> elements, Comparer.ISpecialComparer<TItem> comparer)
        {
            for (var i = 0; i < elements.Count; i++)
            {
                for (var j = i + 1; j < elements.Count; j++)
                {
                    if (comparer.Compare(elements[j], elements[i]) < 0)
                    {
                        SwapMechanism<TItem>.SwapElemets(ref elements, i, j);
                    }
                }
            }
        }
    }
}
