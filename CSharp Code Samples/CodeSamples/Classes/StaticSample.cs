using System;

namespace CodeSamples.Classes
{
    internal static class StaticClass
    {
        static readonly int Constant = 10;

        static StaticClass()
        {
            Console.WriteLine($"Called static constructor of StaticClass, property {nameof(Constant)} = {Constant}");
        }
    }

    public class StaticSample : SampleExecute
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
