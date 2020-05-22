using System;

namespace CodeSamples.Useful
{
    public class OverflowCheckSample : SampleExecute
    {
        public override void Execute()
        {
            Title("OverflowCheckSampleExecute");

            int firstValue;
            int secondValue;

            int maxValue = 2147483647;
            const int maxInt = int.MaxValue;

            //do not check for overflow
            unchecked
            {
                firstValue = 2147483647 + 100;
            }
            Console.WriteLine($"Unchecked sum 1 (in block) (overflow) = {firstValue}");
            //...or...
            firstValue = unchecked(maxInt + 100);

            Console.WriteLine($"Unchecked sum 1 (inline) (overflow) = {firstValue}");

            //unchecked by default at compile time and run time because it contains variables
            secondValue = maxValue + 100;
            Console.WriteLine($"Unchecked sum 2 (variabled added) (overflow) = {secondValue}");

            //catch overflow at run time
            try
            {
                checked
                {
                    secondValue = maxValue + 100;
                }
                Console.WriteLine($"Unchecked sum 2 (in block) (overflow) = {secondValue}");
                //...or...
                secondValue = unchecked(maxValue + 100);
                Console.WriteLine($"Unchecked sum 2 (inline) (overflow) = {secondValue}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception '{e.GetType().Name}' with message '{e.Message}' was thrown.");
            }

            Finish();
        }
    }
}
