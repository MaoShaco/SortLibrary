using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary.SortMechanism.SortAlgorithm
{
    public class HeapAlgorithm<TItem> : ISortAlgorithm<TItem>
    {

        public void SortWithAlgorithm(ref List<TItem> elements, ISpecialComparer<TItem> comparer)
        {
            for (var i = elements.Count / 2 - 1; i >= 0; i--)
            {
                ShiftDown(elements, i, elements.Count, comparer);
            }


            for (var i = elements.Count - 1; i >= 1; i--)
            {
                var temp = elements[0];
                elements[0] = elements[i];
                elements[i] = temp;
                ShiftDown(elements, 0, i, comparer);
            }
        }

        protected void ShiftDown(IList<TItem> elements, int leftBound, int rightBound, ISpecialComparer<TItem> comparer)
        {

            while ((leftBound * 2 + 1 < rightBound))
            {
                var maxChild = leftBound * 2 + 1;
                if (leftBound * 2 + 1 != rightBound - 1 &&
                    comparer.Compare(elements[leftBound * 2 + 1], elements[leftBound * 2 + 2]) != 1)
                {
                    maxChild++;
                }

                if (comparer.Compare(elements[leftBound], elements[maxChild]) != -1)
                {
                    break;
                }

                var temp = elements[leftBound];
                elements[leftBound] = elements[maxChild];
                elements[maxChild] = temp;
                leftBound = maxChild;
            }
        }
    }
}