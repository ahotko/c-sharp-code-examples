using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CodeSamples.Useful
{
    #region Sample Class
    public sealed class LinqSampleClass : IEquatable<LinqSampleClass>
    {
        public string Name { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Place { get; set; } = String.Empty;
        public int Age { get; set; } = 0;

        public bool Equals(LinqSampleClass other)
        {
            //compare only by name, lastname and place, disregard age
            if (other is null) return false;
            return (other.Name.Equals(Name) && other.LastName.Equals(LastName) && other.Place.Equals(Place));
        }
    }
    #endregion

    public class LinqSample : SampleExecute
    {
        List<LinqSampleClass> _sampleList = new List<LinqSampleClass>();

        private void PrepareList(int sampleCount)
        {
            #region Source Collections
            var names = new Collection<string>()     { "Sasha", "Ria", "Kaseem", "Eve", "Keegan", "Giacomo", "Alana", "Katelyn",
                                                       "Wilma", "Lucius", "Herman", "Erasmus", "Eden", "Helen", "Nora", "Owen",
                                                       "Chelsea", "Timon", "Frances", "Shellie", "Darryl", "Chantale", "Natalie",
                                                       "Barclay", "Medge", "Emmanuel", "Tarik", "Jakeem", "Serena", "Ramona",
                                                       "Jelani", "Daryl", "Adara", "Willow", "Colby", "Kieran", "Amaya", "Callum",
                                                       "Rose", "Keith", "Derek", "Thane", "Guinevere", "Alea", "Kiona", "Karen",
                                                       "Lacy", "Georgia", "Francis", "Madeson", "Lucian", "Zachery", "Clark",
                                                       "Colleen", "George", "Jermaine", "Fitzgerald", "Heidi", "Ferris", "Salvador",
                                                       "Channing", "Wesley", "Noel", "Nathaniel", "Lacey", "Paki", "Xandra", "Kim",
                                                       "Mia", "Cameran", "Hasad", "Ariana", "Sydnee", "Blaze", "Madison", "Gary",
                                                       "Kadeem", "Nayda", "Martena", "Lesley", "Tate", "Harrison", "Summer", "Lillian",
                                                       "Tanner", "Harding", "John", "Hiroko", "Nathan", "Jocelyn", "Yael", "Kirsten",
                                                       "Genevieve", "Alika", "Knox", "Perry" };
            var lastNames = new Collection<string>() { "Greer", "Lindsey", "Miller", "Casey", "Whitley", "O'connor", "Edwards",
                                                       "Pace", "York", "Nicholson", "Pope", "Alvarado", "Powell", "Craig", "Stout",
                                                       "Strong" };
            var places = new Collection<string>()    { "Rio Verde", "Sherborne", "Bolano", "Waver", "Sclayn" };
            #endregion

            int maxAvailableSamples = names.Count * lastNames.Count * places.Count;
            if (sampleCount > maxAvailableSamples)
                throw new ArgumentOutOfRangeException("sampleCount", $"Requested sample count ({sampleCount}) too big. Max available count is {maxAvailableSamples}");

            #region Long list of names
            _sampleList = new List<LinqSampleClass>();
            int count = 0;
            var random = new Random();

            do
            {
                var sample = new LinqSampleClass()
                                    {
                                        Name = names[random.Next(names.Count)],
                                        LastName = lastNames[random.Next(lastNames.Count)],
                                        Place = places[random.Next(places.Count)],
                                        Age = random.Next(Constants.Linq.MinAge, Constants.Linq.MaxAge)
                                    };
                //ensure only different persons by name, lastname and place
                if (!_sampleList.Contains(sample))
                {
                    _sampleList.Add(sample);
                    count++;
                }
            } while (count < sampleCount);
            #endregion
        }

        public LinqSample()
        {
            PrepareList(Constants.Linq.MaxSamples);
        }

        private void SumAgeSimple()
        {
            int sumAge = _sampleList.Select(x => x.Age).Sum();
            Console.WriteLine($"Sum with Select = {sumAge}");
            //...or...
            sumAge = _sampleList.Sum(x => x.Age);
            Console.WriteLine($"Sum without Select = {sumAge}");
        }

        private void AverageAge()
        {
            double avgAge = _sampleList.Select(x => x.Age).Average();
            Console.WriteLine($"Average = {avgAge:N1}");
            //...or...
            avgAge = _sampleList.Select(x => x.Age).Where(x => x > 5).Average();
            Console.WriteLine($"Average when (age > 5) = {avgAge:N1}");
            //...or...
            avgAge = _sampleList.Where(x => x.Age > 10).Select(x => x.Age).Average();
            Console.WriteLine($"Average when (age > 10) = {avgAge:N1}");
        }

        private void SumAgeByLastnameGrouping()
        {
            var ageLastnameGroups =
                from sample in _sampleList
                group sample by sample.LastName into sampleGroup
                select
                new
                {
                    Group = sampleGroup.Key,
                    SumAge = sampleGroup.Sum(x => x.Age),
                    CountMembers = sampleGroup.Count()
                };
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.Group}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }


        private void SumAgeByLastnameGroupingOrderedDescending()
        {
            var ageLastnameGroups =
                (from sample in _sampleList
                 group sample by sample.LastName into sampleGroup
                 select
                 new
                 {
                     Group = sampleGroup.Key,
                     SumAge = sampleGroup.Sum(x => x.Age),
                     CountMembers = sampleGroup.Count()
                 }).OrderByDescending(x => x.CountMembers);
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.Group}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGrouping()
        {
            var ageLastnameGroups =
                from sample in _sampleList
                group sample by new { sample.LastName, sample.Place } into sampleGroup
                select
                new
                {
                    GroupingKey = sampleGroup.Key,
                    SumAge = sampleGroup.Sum(x => x.Age),
                    CountMembers = sampleGroup.Count()
                };
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGroupingWithLet()
        {
            var ageLastnameGroups =
                from sample in _sampleList
                group sample by new 
                { 
                    sample.LastName, 
                    sample.Place
                } 
                into sampleGroup
                let sumAge = sampleGroup.Sum(x => x.Age)
                let memberCount = sampleGroup.Count()
                select
                new
                {
                    GroupingKey = sampleGroup.Key,
                    SumAge = sumAge,
                    CountMembers = memberCount
                };
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGroupingOrdered()
        {
            var ageLastnameGroups =
                (from sample in _sampleList
                 group sample by new { sample.LastName, sample.Place } into sampleGroup
                 select
                 new
                 {
                     GroupingKey = sampleGroup.Key,
                     SumAge = sampleGroup.Sum(x => x.Age),
                     CountMembers = sampleGroup.Count()
                 }).OrderBy(x => x.CountMembers);
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGroupingOrderedTop5()
        {
            var ageLastnameGroups =
                (from sample in _sampleList
                 group sample by new { sample.LastName, sample.Place } into sampleGroup
                 select
                 new
                 {
                     GroupingKey = sampleGroup.Key,
                     SumAge = sampleGroup.Sum(x => x.Age),
                     CountMembers = sampleGroup.Count()
                 }).OrderByDescending(x => x.CountMembers).Take(5);
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGroupingOrderedSecond5()
        {
            var ageLastnameGroups =
                (from sample in _sampleList
                 group sample by new { sample.LastName, sample.Place } into sampleGroup
                 select
                 new
                 {
                     GroupingKey = sampleGroup.Key,
                     SumAge = sampleGroup.Sum(x => x.Age),
                     CountMembers = sampleGroup.Count()
                 }).OrderByDescending(x => x.CountMembers).Skip(5).Take(5);
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGroupingOrderedLast5()
        {
            var ageLastnameGroups =
                (from sample in _sampleList
                 group sample by new { sample.LastName, sample.Place } into sampleGroup
                 select
                 new
                 {
                     GroupingKey = sampleGroup.Key,
                     SumAge = sampleGroup.Sum(x => x.Age),
                     CountMembers = sampleGroup.Count()
                 }).OrderByDescending(x => x.CountMembers);
            var last5AgeLastnameGroups = ageLastnameGroups.Skip(Math.Max(0, ageLastnameGroups.Count() - 5));
            //use result
            foreach (var sample in last5AgeLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void SumAgeByLastnameAndPlaceGroupingOrderedTwice()
        {
            var ageLastnameGroups =
                (from sample in _sampleList
                 group sample by new { sample.LastName, sample.Place } into sampleGroup
                 select
                 new
                 {
                     GroupingKey = sampleGroup.Key,
                     SumAge = sampleGroup.Sum(x => x.Age),
                     CountMembers = sampleGroup.Count()
                 }).OrderBy(x => x.GroupingKey.Place).ThenBy(x => x.CountMembers);
            //use result
            foreach (var sample in ageLastnameGroups)
            {
                Console.WriteLine($"Lastname = {sample.GroupingKey.LastName}, Place = {sample.GroupingKey.Place}, {sample.CountMembers} member(s), SumAge = {sample.SumAge}");
            }
        }

        private void ListPeopleBetweenTwoAges(int lowerBound, int upperBound)
        {
            var nameList =
                 from sample in _sampleList
                 where sample.Age >= lowerBound && sample.Age <= upperBound
                 select new { Name = sample.Name + " " + sample.LastName, sample.Age };

            //use result
            foreach (var sample in nameList)
            {
                Console.WriteLine($"Name = {sample.Name}, Age = {sample.Age}");
            }
        }

        public override void Execute()
        {
            Title("LinqSampleExecute");
            SumAgeSimple();
            LineBreak();
            AverageAge();
            LineBreak();
            Section("Group by LastName");
            SumAgeByLastnameGrouping();
            LineBreak();
            Section("Group by LastName and Place");
            SumAgeByLastnameAndPlaceGrouping();
            LineBreak();
            Section("Group by LastName and Place (using 'let' keyword)");
            SumAgeByLastnameAndPlaceGroupingWithLet();
            LineBreak();
            Section("Group by LastName (ordered by member count, desc)");
            SumAgeByLastnameGroupingOrderedDescending();
            LineBreak();
            Section("Group by LastName and Place (ordered by member count)");
            SumAgeByLastnameAndPlaceGroupingOrdered();
            LineBreak();
            Section("Group by LastName and Place (ordered by place and member count)");
            SumAgeByLastnameAndPlaceGroupingOrderedTwice();
            LineBreak();
            Section("Group by LastName and Place (top 5, ordered by member count)");
            SumAgeByLastnameAndPlaceGroupingOrderedTop5();
            LineBreak();
            Section("Group by LastName and Place (records 6..10, ordered by member count)");
            SumAgeByLastnameAndPlaceGroupingOrderedSecond5();
            LineBreak();
            Section("Group by LastName and Place (last 5, ordered by member count)");
            SumAgeByLastnameAndPlaceGroupingOrderedLast5();
            LineBreak();
            Section("People between ages 15 and 35");
            ListPeopleBetweenTwoAges(15, 35);
            Finish();
        }
    }
}
