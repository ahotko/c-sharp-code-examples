using System;

namespace CodeSamples.Attributes
{
    sealed class ObsoleteExamples
    {
        //with "false" as the last parameter, compiler warning will be generated, if property is used anywhere
        [Obsolete("This property is obsolete.", false)]
        public string OldStringValue { get; set; }

        //with "true" as the last parameter, compiler error will be generated, if method is called anywhere
        [Obsolete("This method is obsolete.", true)]
        public int OldGetIntValue()
        {
            return 5 * 2;
        }
    }

    public class ObsoleteSample : SampleExecute
    {
        public override void Execute()
        {
            Title("ObsoleteSampleExecute");
            Section("Creating class (messages only at compile time)");
            ObsoleteExamples obsoleteExample = new ObsoleteExamples();
            //following line produces compiler warning
            obsoleteExample.OldStringValue = String.Empty;
            //following line produces compiler error, if uncommented
            //int value = obsoleteExample.OldGetIntValue();
            Finish();
        }
    }
}
