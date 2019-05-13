using System;

namespace CodeSamples.TupleDeconstruction
{
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

            (var firstName1, var lastName1) = user;
            (var firstName2, var lastName2, var age) = user;

            Title("TupleDeconstructionExecute");
            Console.WriteLine($"First deconstruction: First Name = {firstName1}, Last Name = {lastName1}");
            Console.WriteLine($"Second deconstruction: First Name = {firstName2}, Last Name = {lastName2}, Age = {age}");
            Finish();
        }
    }
}
