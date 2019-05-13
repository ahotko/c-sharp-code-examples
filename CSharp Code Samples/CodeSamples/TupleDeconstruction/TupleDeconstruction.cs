using System;

namespace CodeSamples.TupleDeconstruction
{
    public class TupleDeconstructionSample
    {
        public void TupleDeconstructionExecute()
        {
            var user = new User()
            {
                FirstName = "Name",
                LastName ="LastName",
                Email = "name.lastname@domain.com",
                Age = 42
            };

            (var firstName1, var lastName1) = user;
            (var firstName2, var lastName2, var age) = user;

            Console.WriteLine($"TupleDeconstructionExecute");
            Console.WriteLine($"First deconstruction: First Name = {firstName1}, Last Name = {lastName1}");
            Console.WriteLine($"Second deconstruction: First Name = {firstName2}, Last Name = {lastName2}, Age = {age}");
            Console.WriteLine();
        }
    }
}
