using System;

namespace CodeSamples.Classes
{
    public class CallerInfoSample : SampleExecute
    {
        public void TraceMessage(string message, 
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine($"Message = {message}");
            Console.WriteLine($"Member (Method) Name = {memberName}");
            Console.WriteLine($"Source File Path = {sourceFilePath}");
            Console.WriteLine($"Line Number = {sourceLineNumber}");
        }

        public override void Execute()
        {
            Title("CallerInfoSampleExecute");
            TraceMessage("Tracing this call...");
            Finish();
        }
    }
}
