using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CodeSamples.UsefulClasses
{
    public class DictionariesSample
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

        public void DictionariesExecute()
        {
            AddToDictionaries();

            Console.WriteLine($"DictionariesExecute");
            //Ordinary dictionary - key must be present; in this case, 1 is the key and should return string "one"
            //the order of elements is not fixed, usually the same as they were added
            foreach (KeyValuePair<int, string> ordinaryElement in _ordinaryDictionary)
            {
                Console.WriteLine($"Ordinary Dictionary: {ordinaryElement.Key} = {ordinaryElement.Value}");
            }
            Console.WriteLine();

            //Ordered dictionary - Maintains order of elements, by which they were inserted
            foreach (DictionaryEntry orderedElement in _orderedDictionary)
            {
                Console.WriteLine($"Ordered Dictionary (foreach): {orderedElement.Key} = {orderedElement.Value}");
            }
            for (int i=0;i< _orderedDictionary.Count; i++)
            {
                var orderedElement = _orderedDictionary[i];
                Console.WriteLine($"Ordered Dictionary (index): {orderedElement}");
            }
            Console.WriteLine();

            //Sorted dictionary - elements are sorted by key
            foreach (KeyValuePair<int, string> sortedElement in _sortedDictionary)
            {
                Console.WriteLine($"Sorted Dictionary: {sortedElement.Key} = {sortedElement.Value}");
            }

            Console.WriteLine();
        }
    }
}
