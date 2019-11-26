#define CONDITION1
#define CONDITION2

using System;
using System.Diagnostics;

namespace CodeSamples.Attributes
{
    public class ConditionalSample : SampleExecute
    {
        [Conditional("CONDITION1")]
        private void MethodCondition1()
        {
            Console.WriteLine("MethodCondition1");
        }

        [Conditional("CONDITION2")]
        private void MethodCondition2()
        {
            Console.WriteLine("MethodCondition2");
        }

        [Conditional("CONDITION3")]
        private void MethodCondition3()
        {
            Console.WriteLine("MethodCondition3");
        }

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        private void MethodCondition1or2()
        {
            Console.WriteLine("MethodCondition1or2");
        }

        [Conditional("CONDITION1"), Conditional("CONDITION3")]
        private void MethodCondition1or3()
        {
            Console.WriteLine("MethodCondition1or3");
        }

        public override void Execute()
        {
            Title("ConditionalSampleExecute");
            MethodCondition1();
            MethodCondition2();
            MethodCondition3();
            MethodCondition1or2();
            MethodCondition1or3();
            Finish();
        }
    }
}
