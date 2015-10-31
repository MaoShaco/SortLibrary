using System;
using System.Collections;
using System.Collections.Generic;
using SortLibrary.SortMechanism;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary
{
    internal class Program
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
            sorter.InitTimeActrion(ShowInfo);
            ISpecialComparer<Gom> comparer = new GomComparer();

            sorter.Sort(gomList, comparer);
        }

        private static void ShowInfo(string time, Type sortAlgorithm, IList list)
        {
            Console.WriteLine($"{sortAlgorithm.Name} Sorted per {time}");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
