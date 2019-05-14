using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeSamples.Useful
{
    #region Sample Class
    public class LinqSampleClass
    {
        public string Name { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Place { get; set; } = String.Empty;
        public int Age { get; set; } = 0;
    }
    #endregion

    public class LinqSample : SampleExecute
    {
        List<LinqSampleClass> _sampleList = new List<LinqSampleClass>();

        private void PrepareList()
        {
            #region Long list of names
            _sampleList = new List<LinqSampleClass>()
            {
                new LinqSampleClass() { Name = "Sasha", LastName = "Greer", Place = "Rio Verde", Age = 18 },
                new LinqSampleClass() { Name = "Ria", LastName = "Lindsey", Place = "Sherborne", Age = 9 },
                new LinqSampleClass() { Name = "Kaseem", LastName = "Miller", Place = "Bolano", Age = 12 },
                new LinqSampleClass() { Name = "Eve", LastName = "Lindsey", Place = "Rio Verde", Age = 14 },
                new LinqSampleClass() { Name = "Keegan", LastName = "Casey", Place = "Bolano", Age = 11 },
                new LinqSampleClass() { Name = "Giacomo", LastName = "Whitley", Place = "Bolano", Age = 23 },
                new LinqSampleClass() { Name = "Alana", LastName = "Oconnor", Place = "Sherborne", Age = 8 },
                new LinqSampleClass() { Name = "Katelyn", LastName = "Whitley", Place = "Waver", Age = 14 },
                new LinqSampleClass() { Name = "Wilma", LastName = "Miller", Place = "Bolano", Age = 28 },
                new LinqSampleClass() { Name = "Lucius", LastName = "Edwards", Place = "Waver", Age = 19 },
                new LinqSampleClass() { Name = "Herman", LastName = "Edwards", Place = "Sherborne", Age = 1 },
                new LinqSampleClass() { Name = "Erasmus", LastName = "Pace", Place = "Sclayn", Age = 7 },
                new LinqSampleClass() { Name = "Eden", LastName = "Greer", Place = "Sclayn", Age = 8 },
                new LinqSampleClass() { Name = "Helen", LastName = "Pace", Place = "Sclayn", Age = 8 },
                new LinqSampleClass() { Name = "Nora", LastName = "Whitley", Place = "Waver", Age = 8 },
                new LinqSampleClass() { Name = "Owen", LastName = "York", Place = "Waver", Age = 22 },
                new LinqSampleClass() { Name = "Chelsea", LastName = "Nicholson", Place = "Sclayn", Age = 23 },
                new LinqSampleClass() { Name = "Timon", LastName = "Pope", Place = "Waver", Age = 12 },
                new LinqSampleClass() { Name = "Frances", LastName = "Edwards", Place = "Rio Verde", Age = 16 },
                new LinqSampleClass() { Name = "Shellie", LastName = "Pope", Place = "Sherborne", Age = 10 },
                new LinqSampleClass() { Name = "Darryl", LastName = "Whitley", Place = "Sclayn", Age = 17 },
                new LinqSampleClass() { Name = "Chantale", LastName = "Oconnor", Place = "Waver", Age = 18 },
                new LinqSampleClass() { Name = "Natalie", LastName = "Alvarado", Place = "Rio Verde", Age = 10 },
                new LinqSampleClass() { Name = "Barclay", LastName = "Oconnor", Place = "Sherborne", Age = 20 },
                new LinqSampleClass() { Name = "Medge", LastName = "Powell", Place = "Bolano", Age = 1 },
                new LinqSampleClass() { Name = "Emmanuel", LastName = "Miller", Place = "Bolano", Age = 9 },
                new LinqSampleClass() { Name = "Tarik", LastName = "Craig", Place = "Rio Verde", Age = 22 },
                new LinqSampleClass() { Name = "Jakeem", LastName = "Lindsey", Place = "Bolano", Age = 28 },
                new LinqSampleClass() { Name = "Lucius", LastName = "Pope", Place = "Sclayn", Age = 3 },
                new LinqSampleClass() { Name = "Serena", LastName = "Stout", Place = "Bolano", Age = 20 },
                new LinqSampleClass() { Name = "Ramona", LastName = "Whitley", Place = "Bolano", Age = 1 },
                new LinqSampleClass() { Name = "Jelani", LastName = "York", Place = "Bolano", Age = 8 },
                new LinqSampleClass() { Name = "Daryl", LastName = "Nicholson", Place = "Rio Verde", Age = 11 },
                new LinqSampleClass() { Name = "Adara", LastName = "York", Place = "Sclayn", Age = 27 },
                new LinqSampleClass() { Name = "Willow", LastName = "Craig", Place = "Waver", Age = 18 },
                new LinqSampleClass() { Name = "Colby", LastName = "Whitley", Place = "Waver", Age = 25 },
                new LinqSampleClass() { Name = "Kieran", LastName = "Lindsey", Place = "Sherborne", Age = 27 },
                new LinqSampleClass() { Name = "Amaya", LastName = "Craig", Place = "Bolano", Age = 16 },
                new LinqSampleClass() { Name = "Callum", LastName = "Pope", Place = "Bolano", Age = 30 },
                new LinqSampleClass() { Name = "Rose", LastName = "Strong", Place = "Sherborne", Age = 17 },
                new LinqSampleClass() { Name = "Keith", LastName = "Strong", Place = "Bolano", Age = 2 },
                new LinqSampleClass() { Name = "Derek", LastName = "Whitley", Place = "Rio Verde", Age = 20 },
                new LinqSampleClass() { Name = "Thane", LastName = "Edwards", Place = "Sherborne", Age = 8 },
                new LinqSampleClass() { Name = "Guinevere", LastName = "Greer", Place = "Sherborne", Age = 27 },
                new LinqSampleClass() { Name = "Alea", LastName = "Pace", Place = "Waver", Age = 11 },
                new LinqSampleClass() { Name = "Kiona", LastName = "Casey", Place = "Sherborne", Age = 8 },
                new LinqSampleClass() { Name = "Karen", LastName = "Pope", Place = "Sherborne", Age = 12 },
                new LinqSampleClass() { Name = "Lacy", LastName = "Oconnor", Place = "Bolano", Age = 29 },
                new LinqSampleClass() { Name = "Georgia", LastName = "York", Place = "Bolano", Age = 20 },
                new LinqSampleClass() { Name = "Francis", LastName = "Stout", Place = "Bolano", Age = 11 },
                new LinqSampleClass() { Name = "Madeson", LastName = "Pope", Place = "Bolano", Age = 12 },
                new LinqSampleClass() { Name = "Lucian", LastName = "Edwards", Place = "Sherborne", Age = 10 },
                new LinqSampleClass() { Name = "Zachery", LastName = "Casey", Place = "Sclayn", Age = 5 },
                new LinqSampleClass() { Name = "Clark", LastName = "Whitley", Place = "Sherborne", Age = 1 },
                new LinqSampleClass() { Name = "Colleen", LastName = "Pace", Place = "Rio Verde", Age = 20 },
                new LinqSampleClass() { Name = "George", LastName = "Stout", Place = "Sclayn", Age = 5 },
                new LinqSampleClass() { Name = "Jermaine", LastName = "Greer", Place = "Waver", Age = 21 },
                new LinqSampleClass() { Name = "Fitzgerald", LastName = "Lindsey", Place = "Sclayn", Age = 10 },
                new LinqSampleClass() { Name = "Heidi", LastName = "Lindsey", Place = "Sherborne", Age = 17 },
                new LinqSampleClass() { Name = "Ferris", LastName = "Miller", Place = "Rio Verde", Age = 22 },
                new LinqSampleClass() { Name = "Salvador", LastName = "Powell", Place = "Sclayn", Age = 15 },
                new LinqSampleClass() { Name = "Channing", LastName = "York", Place = "Waver", Age = 27 },
                new LinqSampleClass() { Name = "Wesley", LastName = "Craig", Place = "Rio Verde", Age = 28 },
                new LinqSampleClass() { Name = "Noel", LastName = "Strong", Place = "Sherborne", Age = 1 },
                new LinqSampleClass() { Name = "Nathaniel", LastName = "Whitley", Place = "Bolano", Age = 27 },
                new LinqSampleClass() { Name = "Daryl", LastName = "Oconnor", Place = "Bolano", Age = 30 },
                new LinqSampleClass() { Name = "Lacey", LastName = "Miller", Place = "Waver", Age = 6 },
                new LinqSampleClass() { Name = "Paki", LastName = "Powell", Place = "Sclayn", Age = 17 },
                new LinqSampleClass() { Name = "Xandra", LastName = "Pace", Place = "Waver", Age = 11 },
                new LinqSampleClass() { Name = "Kim", LastName = "Lindsey", Place = "Bolano", Age = 15 },
                new LinqSampleClass() { Name = "Mia", LastName = "Alvarado", Place = "Rio Verde", Age = 10 },
                new LinqSampleClass() { Name = "Cameran", LastName = "Pace", Place = "Bolano", Age = 30 },
                new LinqSampleClass() { Name = "Hasad", LastName = "Casey", Place = "Sclayn", Age = 2 },
                new LinqSampleClass() { Name = "Ariana", LastName = "Edwards", Place = "Bolano", Age = 16 },
                new LinqSampleClass() { Name = "Sydnee", LastName = "York", Place = "Bolano", Age = 8 },
                new LinqSampleClass() { Name = "Kiona", LastName = "Whitley", Place = "Sclayn", Age = 1 },
                new LinqSampleClass() { Name = "Blaze", LastName = "Pope", Place = "Sherborne", Age = 4 },
                new LinqSampleClass() { Name = "Madison", LastName = "Edwards", Place = "Waver", Age = 27 },
                new LinqSampleClass() { Name = "Gary", LastName = "Stout", Place = "Sclayn", Age = 29 },
                new LinqSampleClass() { Name = "Kadeem", LastName = "York", Place = "Bolano", Age = 26 },
                new LinqSampleClass() { Name = "Nayda", LastName = "Pope", Place = "Bolano", Age = 24 },
                new LinqSampleClass() { Name = "Martena", LastName = "Miller", Place = "Rio Verde", Age = 13 },
                new LinqSampleClass() { Name = "Lesley", LastName = "Casey", Place = "Sclayn", Age = 8 },
                new LinqSampleClass() { Name = "Tate", LastName = "Casey", Place = "Sherborne", Age = 27 },
                new LinqSampleClass() { Name = "Harrison", LastName = "Craig", Place = "Sclayn", Age = 18 },
                new LinqSampleClass() { Name = "Wilma", LastName = "Casey", Place = "Sclayn", Age = 11 },
                new LinqSampleClass() { Name = "Summer", LastName = "Strong", Place = "Bolano", Age = 3 },
                new LinqSampleClass() { Name = "Lillian", LastName = "Stout", Place = "Bolano", Age = 10 },
                new LinqSampleClass() { Name = "Tanner", LastName = "Stout", Place = "Sherborne", Age = 1 },
                new LinqSampleClass() { Name = "Harding", LastName = "Lindsey", Place = "Sclayn", Age = 3 },
                new LinqSampleClass() { Name = "John", LastName = "Lindsey", Place = "Waver", Age = 26 },
                new LinqSampleClass() { Name = "Hiroko", LastName = "Miller", Place = "Rio Verde", Age = 14 },
                new LinqSampleClass() { Name = "Nathan", LastName = "Powell", Place = "Rio Verde", Age = 29 },
                new LinqSampleClass() { Name = "Jocelyn", LastName = "Miller", Place = "Bolano", Age = 17 },
                new LinqSampleClass() { Name = "Yael", LastName = "Craig", Place = "Sclayn", Age = 8 },
                new LinqSampleClass() { Name = "Kirsten", LastName = "Whitley", Place = "Rio Verde", Age = 26 },
                new LinqSampleClass() { Name = "Genevieve", LastName = "Nicholson", Place = "Bolano", Age = 16 },
                new LinqSampleClass() { Name = "Alika", LastName = "Miller", Place = "Sherborne", Age = 29 },
                new LinqSampleClass() { Name = "Knox", LastName = "Edwards", Place = "Sherborne", Age = 5 },
                new LinqSampleClass() { Name = "Perry", LastName = "Strong", Place = "Rio Verde", Age = 3 }
            };
            #endregion
        }

        public LinqSample()
        {
            PrepareList();
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
            Finish();
        }
    }
}
