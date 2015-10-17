using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary.SortMechanism.SortAlgorithm
{
    internal class ShellAlgorithm<TItem> : ISortAlgorithm<TItem>
    {
        public void SortWithAlgorithm(ref List<TItem> elements, ISpecialComparer<TItem> comparer)
        {
            var step = elements.Count / 2;
            while (step > 0)
            {
                for (var i = step; i < elements.Count; i++)
                {
                    for (int j = i - step; (j >= 0) && comparer.Compare(elements[j], elements[i]) > 0; j -= step)
                        SwapMechanism.SwapMechanism<TItem>.SwapElemets(ref elements, j + step, j);
                }
                step /= 2;
            }
        }
    }
}
