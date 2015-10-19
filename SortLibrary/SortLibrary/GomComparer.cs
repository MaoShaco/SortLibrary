using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary
{
    class GomComparer : ISpecialComparer<Gom>
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
}
