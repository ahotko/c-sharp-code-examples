using System;
using System.Text.RegularExpressions;

namespace CodeSamples.RegularExpressions
{
    public class RegExSample : SampleExecute
    {
        private void IsMatchSnipet()
        {
            string pattern = @"^This sentence";
            string sentenceYes = $"This sentence is a match.";
            string sentenceNo = $"This weird sentence is not a match.";

            Console.WriteLine($"The sentence '{sentenceYes}' is {(Regex.IsMatch(sentenceYes, pattern) ? "" : "not")} a match to pattern '{pattern}'");
            Console.WriteLine($"The sentence '{sentenceNo}' is {(Regex.IsMatch(sentenceNo, pattern) ? "" : "not")} a match to pattern '{pattern}'");
        }

        public override void Execute()
        {
            Title("RegExSampleExecute");

            IsMatchSnipet();

            Finish();
        }
    }
}
