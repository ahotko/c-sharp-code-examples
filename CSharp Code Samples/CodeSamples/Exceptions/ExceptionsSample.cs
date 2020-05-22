using System;

namespace CodeSamples.Exceptions
{
    internal class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }

    public class ExceptionsSample : SampleExecute
    {
        public override void Execute()
        {
            try
            {
                throw new MyException("My Exception!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception '{e.GetType().Name}' with message '{e.Message}' was thrown.");
            }
        }
    }
}
