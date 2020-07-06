using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CodeSamples.UsefulClasses
{
    public class CollectionInitializerSamples : SampleExecute
    {
        private void Lists()
        {
            var list = new List<int>() { 1, 2, 3 };
            Console.WriteLine($"List Contents: {string.Join(", ", list)}");

            list.Add(12);
            Console.WriteLine($"List Contents After Addition: {string.Join(", ", list)}");
        }

        private void Collections()
        {
            var collection = new Collection<int>() { 1, 2, 3 };
            Console.WriteLine($"Collection Contents: {string.Join(", ", collection)}");

            collection.Add(21);
            Console.WriteLine($"Collection Contents After Addition: {string.Join(", ", collection)}");
        }

        private void Dictionaries()
        {
            var dictionary = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3
            };
            Console.WriteLine($"Collection Contents: {string.Join(", ", dictionary.Select(kv => kv.Key + "=" + kv.Value).ToArray())}");

            dictionary.Add("zero", 0);
            Console.WriteLine($"Collection Contents After Addition: {string.Join(", ", dictionary.Select(kv => kv.Key + "=" + kv.Value).ToArray())}");
        }

        private void Arrays()
        {
            var array = new int[] { 4, 5, 6 };
            Console.WriteLine($"Array Contents: {string.Join(", ", array)}");

            //array resize
            Array.Resize(ref array, 4);
            array[3] = 55;
            Console.WriteLine($"Array Contents After Resize & Addition: {string.Join(", ", array)}");
        }

        public override void Execute()
        {
            Title("CollectionInitializerSamplesExecute");

            Section("Lists");
            Lists();

            Section("Collections");
            Collections();

            Section("Arrays");
            Arrays();

            Section("Dictionaries");
            Dictionaries();

            Finish();
        }
    }
}
