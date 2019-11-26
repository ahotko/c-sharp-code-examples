using System;

namespace CodeSamples.SyntacticSugars
{
    public class NullSample : SampleExecute
    {
        public override void Execute()
        {
            Title("NullSampleExecute");

            Object obj = null;

            if(obj is null)
            {
                Console.WriteLine("Object is null.");
            }

            if (obj is object)
            {
                Console.WriteLine("Object is not null.");
            }

            Finish();
        }
    }
}
