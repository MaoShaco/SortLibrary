using System;

namespace SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm
{
    public class AlgorithmSwitch<TItem>
    {
        public ISortAlgorithm<TItem> GetSortAlgorithm(AlgorithmType algorithmName, string nameSpacePath = null)
        {
            if(nameSpacePath == null)
                nameSpacePath = typeof (ISortAlgorithm<>).Namespace;

            var type = Type.GetType($"{nameSpacePath}.{algorithmName}Algorithm`1");
            if (type != null)
                return
                    (ISortAlgorithm<TItem>)
                        Activator.CreateInstance(
                            type
                                .MakeGenericType(typeof (TItem)));
            throw new ArgumentException();
        }
    }
}
