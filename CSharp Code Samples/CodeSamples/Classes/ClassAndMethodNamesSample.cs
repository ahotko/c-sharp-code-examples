using System;

namespace CodeSamples.Classes
{
    public class ClassAndMethodNamesSample : SampleExecute
    {
        public override void Execute()
        {
            string className = this.GetType().Name;
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            Title("ClassAndMethodNamesSampleExecute");
            Console.WriteLine($"This Class Name = {className}");
            Console.WriteLine($"This Method Name = {methodName}");
            Finish();
        }

    }
}
