using System;

namespace CodeSamples.TupleDeconstruction
{
    #region Worker Class
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }

        public (string, int) GetNameAndAge()
        {
            return ($"{FirstName} {LastName}", Age);
        }

        public (string fullName, int age) GetNameAndAgeNamed()
        {
            return ($"{FirstName} {LastName}", Age);
        }
    }
    #endregion

    public class TupleDeconstructionSample : SampleExecute
    {
        public override void Execute()
        {
            var user = new User()
            {
                FirstName = "Name",
                LastName = "LastName",
                Email = "name.lastname@domain.com",
                Age = 42
            };

            (var firstName1, var lastName1) = user; //using Deconstruct method
            (var firstName2, var lastName2, var age) = user; //using Deconstruct method

            var unnamedTuple = user.GetNameAndAge();
            var namedTuple = user.GetNameAndAgeNamed();
            (string tupleFullNameTyped, int tupleAgeTyped) = user.GetNameAndAge();
            var (tupleFullNameVar, tupleAgeVar) = user.GetNameAndAge();

            Title("TupleDeconstructionExecute");
            Console.WriteLine($"First deconstruction: First Name = {firstName1}, Last Name = {lastName1}");
            Console.WriteLine($"Second deconstruction: First Name = {firstName2}, Last Name = {lastName2}, Age = {age}");
            Console.WriteLine($"Unnamed Tuple: Name = {unnamedTuple.Item1}, Age = {unnamedTuple.Item2}");
            Console.WriteLine($"Named Tuple: Name = {namedTuple.fullName}, Age = {namedTuple.age}");
            Console.WriteLine($"Typed Params: Name = {tupleFullNameTyped}, Age = {tupleAgeTyped}");
            Console.WriteLine($"Untyped (var) Params: Name = {tupleFullNameVar}, Age = {tupleAgeVar}");
            Finish();
        }
    }
}
