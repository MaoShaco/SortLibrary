namespace SortLibrary.SortMechanism.SortAlgorithm.SwitchAlgorithm
{
    public static class AlgorithmSwitch<TItem>
    {
        public static ISortAlgorithm<TItem> SwitchAlgorithm(AlgorithmType algorithm)
        {
            switch (algorithm)
            {
                case AlgorithmType.Bubble:
                    return new BubbleAlgorithm<TItem>();
                case AlgorithmType.Shell:
                    return new ShellAlgorithm<TItem>();
                case AlgorithmType.Tree:
                    return new TreeAlgorithm<TItem>();
                default:
                    return new BubbleAlgorithm<TItem>();
            }
        }
    }
}
