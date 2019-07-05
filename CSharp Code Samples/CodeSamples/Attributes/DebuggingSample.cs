#if !DEBUG
#define RELEASE
#endif

using System;
using System.Diagnostics;

namespace CodeSamples.Attributes
{
    sealed class FullName
    {
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    sealed class DebuggerExamplesDebuggerBrowsable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
        public string UsernameProperty { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string HiddenInDebuggerWindow { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public FullName OnlyPropertiesOfClassVisibleInDebuggerWindow { get; set; }
    }

    [DebuggerDisplay("StringValue = {StringValue}, IntValue = {GetIntValue()}")]
    sealed class DebuggerExamplesDebuggerDisplay
    {
        public string StringValue { get; set; } = "SomeStringValue";
        public int GetIntValue()
        {
            return 5*2;
        }

        [Conditional("DEBUG")]
        public void ExecuteOnlyInDebugMode()
        {
            Console.WriteLine($"Executed in DEBUG mode");
        }

        [Conditional("RELEASE")]
        public void ExecuteOnlyInReleaseMode()
        {
            Console.WriteLine($"Executed in RELEASE mode");
        }

#if DEBUG
        public void CompileOnlyWhenDebugDefined()
        {
            Console.WriteLine($"Compiled and Executed in DEBUG mode");
        }
#endif

#if !DEBUG
        public void CompileOnlyWhenDebugNotDefined()
        {
            Console.WriteLine($"Compiled and Executed in RELEASE mode");
        }
#endif

        public void RuntimeDebuggerAttached()
        {
            string debuggerAttached = Debugger.IsAttached ? "is" : "is not";
            Console.WriteLine($"Runtime Debugger Checking: Debugger {debuggerAttached} attached");
        }

        [DebuggerStepThrough]
        public void DebuggerStepThroughMethod()
        {
            Console.WriteLine($"Debugger stepped through this method.");
        }
    }

    public class DebuggingSample : SampleExecute
    {
        public override void Execute()
        {
            Title("DebuggingSampleExecute");
            Section("Creating class (if breakpoint is used here, debugger output will be formatted as in DebuggerDisplay())");
            DebuggerExamplesDebuggerDisplay debuggerExample = new DebuggerExamplesDebuggerDisplay();
            //set breakpoint on next line and hover over "debuggerExample" variable
            debuggerExample.DebuggerStepThroughMethod();
            debuggerExample.ExecuteOnlyInDebugMode();
            debuggerExample.ExecuteOnlyInReleaseMode();
            debuggerExample.RuntimeDebuggerAttached();
            Finish();
        }
    }
}
