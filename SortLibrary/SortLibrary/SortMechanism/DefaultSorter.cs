using System;
using System.Collections.Generic;
using System.Diagnostics;
using SortLibrary.SortMechanism.Comparer;
using SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm;

namespace SortLibrary.SortMechanism
{
    class DefaultSorter<TItem> : Sorter<TItem>
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
            //var a = new ShellAlgorithm<TItem>();
            //var a = new BubbleAlgorithm<TItem>();
            //var a = new TreeAlgorithm<TItem>();
            var a = AlgorithmSwitch<TItem>.SwitchAlgorithm(algorithm);
            a.SortWithAlgorithm(ref elements, comparer);
            _timeAction?.Invoke(timer.ElapsedTicks.ToString());
            timer.Stop();
        }
    }
}
