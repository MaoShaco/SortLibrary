using System.Collections.Generic;

namespace SortLibrary.SortMechanism.SortAlgorithm.SwapMechanism
{
    static internal class SwapMechanism<TItem>
    {
        public static void SwapElemets(ref List<TItem> elemetns, int indexFirst, int indexSecond)
        {
            var temp = elemetns[indexFirst];
            elemetns[indexFirst] = elemetns[indexSecond];
            elemetns[indexSecond] = temp;
        }
    }
}
