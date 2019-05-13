using System;

namespace CodeSamples.Useful
{
    public class UsefulSample : SampleExecute
    {
        public override void Execute()
        {
            string className = this.GetType().Name;
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            Title("UsefulSampleExecute");
            Console.WriteLine($"This Class Name = {className}");
            Console.WriteLine($"This Method Name = {methodName}");
            Finish();
        }

    }
}
