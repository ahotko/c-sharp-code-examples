using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CodeSamples.Comparing
{
    public class CompareSample : SampleExecute
    {
        private void EquatableAddToList(Collection<EquatableSample> list, EquatableSample item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                Console.WriteLine($"Added Sample {item.ToString()}");
            }
            else
            {
                Console.WriteLine($"Sample '{item.ToString()}' already in list; not added");
            }
        }

        private void EquatableSample()
        {
            var list = new Collection<EquatableSample>();

            var item1 = new EquatableSample() { IntProperty = 1, StringProperty = "One" };
            var item2 = new EquatableSample() { IntProperty = 1, StringProperty = "Two" };
            var item3 = new EquatableSample() { IntProperty = 3, StringProperty = "Three" };
            var item4 = new EquatableSample() { IntProperty = 1, StringProperty = "One" };

            EquatableAddToList(list, item1);
            EquatableAddToList(list, item2);
            EquatableAddToList(list, item3);
            EquatableAddToList(list, item4);
        }

        private void EqualityComparerAddToList(Dictionary<EqualityComparerSample, string> list, EqualityComparerSample item)
        {
            try
            {
                list.Add(item, item.StringProperty);
                Console.WriteLine($"Added Sample {item.ToString()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sample '{item.ToString()}' already in list; not added");
            }
        }

        private void EqualityComparerSample()
        {
            //IEqualityComparer<T> is only for dictionaries
            var list = new Dictionary<EqualityComparerSample, string>(new EqualityComparer());

            var item1 = new EqualityComparerSample() { IntProperty = 1, StringProperty = "One" };
            var item2 = new EqualityComparerSample() { IntProperty = 1, StringProperty = "Two" };
            var item3 = new EqualityComparerSample() { IntProperty = 3, StringProperty = "Three" };
            var item4 = new EqualityComparerSample() { IntProperty = 1, StringProperty = "One" };

            EqualityComparerAddToList(list, item1);
            EqualityComparerAddToList(list, item2);
            EqualityComparerAddToList(list, item3);
            EqualityComparerAddToList(list, item4);
        }

        public override void Execute()
        {
            Title("CompareSampleExecute");
            LineBreak();
            Section("IEquatable<T> Sample");
            EquatableSample();
            LineBreak();
            Section("IEqualityComparer<T> Sample");
            EqualityComparerSample();
            LineBreak();
            Finish();
        }
    }
}
