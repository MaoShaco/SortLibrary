using System;
using System.Collections.Generic;
using SortLibrary.SortMechanism;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm;

namespace SortLibrary
{
    class Gom : IComparable
    {
        public int A { get; }
        public int B { get; }

        public Gom(int a, int b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
        {
            return $"({A},{B})";
        }

        public int CompareTo(object obj)
        {
            return A.CompareTo(((Gom) obj).A);
        }
    }

    class SsComparer : ISpecialComparer<Gom>
    {
        public int Compare(Gom x, Gom y)
        {
            return x.B.CompareTo(y.B);
        }

        int ISpecialComparer<Gom>.Compare(Gom objectA, Gom objectB)
        {
            return Compare(objectA, objectB);
        }
    }

    class Program
    {
        static void Main()
        {
            //var aList = new List<int> {6, 23, 4, 9, 4, 667, 98, 34, 2123123, 46};
            var gomList = new List<Gom> {new Gom(45,12), new Gom(12,66), new Gom(4,-50), new Gom(0,30), new Gom(4,12), new Gom(-65,33)};

            Sorter<Gom> a = new DefaultSorter<Gom>();
            ISpecialComparer<Gom> b = new SsComparer();

            try
            {
                a.Sort(ref gomList, b, AlgorithmType.Tree);
            }
            catch (InvalidCastException argument)
            {
                Console.WriteLine(argument.Message);
            }


            foreach (Gom itemGom in gomList)
            {
                Console.WriteLine(itemGom);
            }
            
        }
    }
}
