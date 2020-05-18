using System;
using System.Collections.Generic;

namespace CodeSamples.Patterns.Behavioral
{
    #region Strategy classes and interfaces
    interface ISortStrategy
    {
        void Sort(List<int> sortableList);
    }

    class QuickSortStrategy : ISortStrategy
    {
        public void Sort(List<int> sortableList)
        {
            Console.WriteLine($"Quick Sort Called...");
        }
    }

    class ShellSortStrategy : ISortStrategy
    {
        public void Sort(List<int> sortableList)
        {
            Console.WriteLine($"Shell Sort Called...");
        }
    }

    class InsertionSortStrategy : ISortStrategy
    {
        public void Sort(List<int> sortableList)
        {
            Console.WriteLine($"Insertion Sort Called...");
        }
    }
    #endregion

    class StrategyTestClass
    {
        private ISortStrategy _sortStrategy = null;
        private readonly List<int> _sortableList = new List<int>() { 5, 3, 7, 12, 100, 1 };

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort()
        {
            _sortStrategy.Sort(_sortableList);
        }
    }

    public class StrategyPatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("Strategy Pattern");
            var testClass = new StrategyTestClass();
            testClass.SetSortStrategy(new QuickSortStrategy());
            testClass.Sort();
            testClass.SetSortStrategy(new ShellSortStrategy());
            testClass.Sort();
            testClass.SetSortStrategy(new InsertionSortStrategy());
            testClass.Sort();
        }
    }
}
