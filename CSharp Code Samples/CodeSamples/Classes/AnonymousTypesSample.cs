using System;

namespace CodeSamples.Classes
{
    public class AnonymousTypesSample : SampleExecute
    {
        /// <summary>
        /// Creates anonymous type (object) with properties Name, Lastname and Age
        /// </summary>
        public override void Execute()
        {
            Title("AnonymousTypesSampleExecute");
            var anonymousObject = new { Name = "Foo", Lastname = "Bar", Age = 13 };
            Console.WriteLine($"anonymousObject(), Name = {anonymousObject.Name}, Lastname = {anonymousObject.Lastname}, Age = {anonymousObject.Age}");
            Finish();
        }
    }
}
