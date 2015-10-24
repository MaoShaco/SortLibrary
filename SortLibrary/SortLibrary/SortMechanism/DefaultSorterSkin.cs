using System;
using System.Collections.Generic;
using System.Diagnostics;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm;

namespace SortLibrary.SortMechanism
{
    class DefaultSorterSkin<TItem> : SorterSkin<TItem>
    {
        private static Action<string> _timeAction;
    

        public void InitTimeActrion(Action<string> timeAction = null)
        {
            _timeAction = timeAction;
        }

        public override void Sort(ref List<TItem> elements, ISpecialComparer<TItem> comparer, AlgorithmType algorithm)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            var algorithmDeterminer = new AlgorithmSwitch<TItem>();
            var sortAlgorithm = algorithmDeterminer.GetSortAlgorithm(algorithm);
            sortAlgorithm.SortWithAlgorithm(ref elements, comparer);
            _timeAction?.Invoke(timer.ElapsedTicks.ToString());
            timer.Stop();
        }
    }
}
