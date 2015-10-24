using System;

namespace SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm
{
    public class AlgorithmSwitch<TItem>
    {
        public ISortAlgorithm<TItem> GetSortAlgorithm(AlgorithmType algorithmName)
        {
            var type = Type.GetType($"SortLibrary.SortMechanism.SortAlgorithm.{algorithmName}Algorithm`1");
            if (type != null)
                return
                    (ISortAlgorithm<TItem>)
                        Activator.CreateInstance(
                            type
                                .MakeGenericType(typeof (TItem)));
            throw new ArgumentNullException();
        }
    }
}
