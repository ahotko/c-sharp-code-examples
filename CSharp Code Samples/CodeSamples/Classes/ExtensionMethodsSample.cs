using System;
using System.Text;

namespace CodeSamples.Classes
{
    public static class ExtensionMethods
    {
        public static string PadRightWithString(this string value, string padding, int paddingCount)
        {
            var result = new StringBuilder(value);
            for (int i = 0; i < paddingCount; i++)
            {
                result.Append(padding);
            }
            return result.ToString();
        }

        public static void WriteToConsole(this string value)
        {
            Console.WriteLine($"Contents Of String = {value}");
        }
    }

    public class ExtensionMethodsSample : SampleExecute
    {
        public override void Execute()
        {
            Title("ExtensionMethodsSampleExecute");
            string testString = "test string";
            string resultString = testString.PadRightWithString("<pad>", 5);
            Console.WriteLine("Original string:");
            testString.WriteToConsole();
            Console.WriteLine("Padded string:");
            resultString.WriteToConsole();
            Finish();
        }
    }
}
