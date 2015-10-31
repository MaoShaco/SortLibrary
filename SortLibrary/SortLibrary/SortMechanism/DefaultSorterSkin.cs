using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm;

namespace SortLibrary.SortMechanism
{
    internal class DefaultSorterSkin<TItem> : SorterSkin<TItem>
    {
        private static Action<string, Type, IList> _timeAction;


        public void InitTimeActrion(Action<string, Type, IList> timeAction = null)
        {
            _timeAction = timeAction;
        }

        public override void Sort(List<TItem> elements, ISpecialComparer<TItem> comparer)
        {
            var instances = from type in Assembly.GetExecutingAssembly().GetTypes()
                where type.IsClass && !type.IsNested && type.Namespace == (typeof (ISortAlgorithm<>).Namespace)
                select type;

            foreach (var type in instances)
            {
                DoSortCycle(elements, comparer,
                    (ISortAlgorithm<TItem>)
                        Activator.CreateInstance(
                            type
                                .MakeGenericType(typeof (TItem))));
            }
        }

        private static void DoSortCycle(List<TItem> elements, ISpecialComparer<TItem> comparer,
            ISortAlgorithm<TItem> sortAlgorithm)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();

            sortAlgorithm.SortWithAlgorithm(ref elements, comparer);
            _timeAction?.Invoke(timer.ElapsedTicks.ToString(), sortAlgorithm.GetType(), elements);

            timer.Stop();
        }
    }
}
