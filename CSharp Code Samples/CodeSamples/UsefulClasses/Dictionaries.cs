using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CodeSamples.UsefulClasses
{
    public class DictionariesSample : SampleExecute
    {
        private Dictionary<int, string> _ordinaryDictionary = new Dictionary<int, string>();
        private OrderedDictionary _orderedDictionary = new OrderedDictionary();
        private SortedDictionary<int, string> _sortedDictionary = new SortedDictionary<int, string>();

        private void AddToDictionaries()
        {
            #region Ordinary Dictionary
            _ordinaryDictionary.Add(1, "one");
            _ordinaryDictionary.Add(3, "three");
            _ordinaryDictionary.Add(2, "two");
            #endregion

            #region Ordered Dictionary
            _orderedDictionary.Add(2, "ordered two");
            _orderedDictionary.Add(1, "ordered one");
            _orderedDictionary.Add(3, "ordered three");
            #endregion

            #region Sorted Dictionary
            _sortedDictionary.Add(3, "sorted three");
            _sortedDictionary.Add(2, "sorted two");
            _sortedDictionary.Add(1, "sorted one");
            #endregion
        }

        public override void Execute()
        {
            AddToDictionaries();

            Title("DictionariesExecute");
            //Ordinary dictionary - key must be present; in this case, 1 is the key and should return string "one"
            //the order of elements is not fixed, usually the same as they were added
            Section("Ordinary Dictionary");
            foreach (KeyValuePair<int, string> ordinaryElement in _ordinaryDictionary)
            {
                Console.WriteLine($"{ordinaryElement.Key} = {ordinaryElement.Value}");
            }
            LineBreak();

            //Ordered dictionary - Maintains order of elements, by which they were inserted
            Section("Ordered Dictionary (foreach)");
            foreach (DictionaryEntry orderedElement in _orderedDictionary)
            {
                Console.WriteLine($"{orderedElement.Key} = {orderedElement.Value}");
            }
            LineBreak();
            Section("Ordered Dictionary (index)");
            for (int i = 0; i < _orderedDictionary.Count; i++)
            {
                var orderedElement = _orderedDictionary[i];
                Console.WriteLine($"{orderedElement}");
            }
            LineBreak();

            //Sorted dictionary - elements are sorted by key
            Section("Sorted Dictionary");
            foreach (KeyValuePair<int, string> sortedElement in _sortedDictionary)
            {
                Console.WriteLine($"{sortedElement.Key} = {sortedElement.Value}");
            }

            Finish();
        }
    }
}
