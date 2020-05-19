using CodeSamples.Alterations.Extensions;
using System;

namespace CodeSamples.Alterations
{
    public class ClassExtensionSample : SampleExecute
    {
        public override void Execute()
        {
            Title("ClassExtensionSample");

            string str = "This Is A String To count All UpperCase characters.";
            Console.WriteLine($"String '{str}' has {str.CountUppercaseCharacters()} uppercase characters.");
            Console.WriteLine($"String '{str}' has {str.CountCharacters('e')} 'e' characters.");

            Finish();
        }
    }
}
