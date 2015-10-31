using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary.SortMechanism.SortAlgorithm
{
    public class ShellAlgorithm<TItem> : ISortAlgorithm<TItem>
    {
        public void SortWithAlgorithm(ref List<TItem> elements, ISpecialComparer<TItem> comparer)
        {
            var step = elements.Count/2;
            while (step > 0)
            {
                for (var i = step; i < elements.Count; i++)
                {
                    for (var j = i - step; (j >= 0) && comparer.Compare(elements[j], elements[i]) > 0; j -= step)
                    {
                        var temp = elements[j + step];
                        elements[j + step] = elements[j];
                        elements[j] = temp;
                    }
                }
                step /= 2;
            }
        }
    }
}
