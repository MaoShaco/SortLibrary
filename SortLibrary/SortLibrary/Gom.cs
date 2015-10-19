using System;

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
            return A.CompareTo(((Gom)obj).A);
        }
    }
}