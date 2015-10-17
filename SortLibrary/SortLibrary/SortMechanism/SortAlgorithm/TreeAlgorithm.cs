using System.Collections.Generic;
using SortLibrary.SortMechanism.Comparer;

namespace SortLibrary.SortMechanism.SortAlgorithm
{
    internal class TreeAlgorithm<TItem> : ISortAlgorithm<TItem>
    {
        public void SortWithAlgorithm(ref List<TItem> elements, ISpecialComparer<TItem> comparer)
        {
            var tree = new Tree(elements[0]);
            for (int i = 1; i < elements.Count; i++)
            {
                tree.Insert(elements[i], comparer);
            }
            elements.Clear();
            tree.Traverse(ref elements);
        }

        internal class Tree
        {
            public Tree Left { get; private set; }
            public Tree Right { get; private set; }
            public TItem Key { get; }

            public Tree(TItem k)
            {
                Key = k;
            }

            public void Insert(TItem aTree, ISpecialComparer<TItem> comparer)
            {
                var buffTree = new Tree(aTree);
                if (comparer.Compare(Key, buffTree.Key) > 0)
                    if (Left != null) Left.Insert(aTree, comparer);
                    else Left = buffTree;
                else if (Right != null) Right.Insert(aTree, comparer);
                else Right = buffTree;
            }

            public void Traverse(ref List<TItem> elements)
            {
                Left?.Traverse(ref elements);

                elements.Add(Key);

                Right?.Traverse(ref elements);
            }
        }


    }
}
