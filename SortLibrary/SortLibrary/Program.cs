using System;
using System.Collections.Generic;
using SortLibrary.SortMechanism;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm;

namespace SortLibrary
{
    class Program
    {
        private static void Main()
        {
            //var intList = new List<int> {6, 23, 4, 9, 4, 667, 98, 34, 2123123, 46};
            var gomList = new List<Gom>
            {
                new Gom(45, 12),
                new Gom(12, 66),
                new Gom(4, -50),
                new Gom(0, 30),
                new Gom(4, 12),
                new Gom(-65, 33)
            };

            var sorter = new DefaultSorterSkin<Gom>();
            sorter.InitTimeActrion(ShowTime);
            ISpecialComparer<Gom> comparer = new GomComparer();

            sorter.Sort(ref gomList, comparer, AlgorithmType.Heap);

            foreach (var item in gomList)
            {
                Console.WriteLine($"{item}");
            }
        }

        private static void ShowTime(string obj)
        {
            Console.WriteLine($"Sorted per {obj}");
        }
    }
}
