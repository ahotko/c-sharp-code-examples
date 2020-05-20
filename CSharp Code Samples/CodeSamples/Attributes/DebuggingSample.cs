#if !DEBUG
#define RELEASE
#else
#define WERE_OK
#endif

#if DEBUG
#warning This is good as it is run in Debug mode
#endif

#if (DEBUG && WERE_OK)
#undef WERE_OK
#endif

#if !DEBUG
#error This should only be run in Debug mode
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

    /// <summary>
    /// <para>
    /// DebuggerBrowsableState.Collapsed - This signifies that the default behaviour should be used for the decorated member and 
    ///      gives the equivalent results as when the attribute is omitted. When viewed in a debugging tool the member is visible 
    ///      and can be expanded to allow access to any further members that it contains.
    /// </para>
    /// <para>
    /// DebuggerBrowsableState.Never - This indicates that the member should not be displayed in debugging windows. The member is 
    ///      hidden from view completely.
    /// </para>
    /// <para>
    /// DebuggerBrowsableState.RootHidden - This signifies that the member should not be visible but that its own members should be. 
    ///      The members of the hidden item appear as if they were one level higher in the hierarchy of values. This setting is useful 
    ///      for members that are used only to store structured information, such as collection types or some data objects.
    /// </para>
    /// </summary>
    sealed class DebuggerExamplesDebuggerBrowsable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
        public string StandardProperty { get; set; }

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

        /// <summary>
        /// Also see <see cref="ConditionalSample"/> class
        /// </summary>
        [Conditional("DEBUG")]
        public void ExecuteOnlyInDebugMode()
        {
            Console.WriteLine("Executed in DEBUG mode");
        }

        /// <summary>
        /// Also see <see cref="ConditionalSample"/> class
        /// </summary>
        [Conditional("RELEASE")]
        public void ExecuteOnlyInReleaseMode()
        {
            Console.WriteLine("Executed in RELEASE mode");
        }

#if DEBUG
        public void CompileOnlyWhenDebugDefined()
        {
            Console.WriteLine("Compiled and Executed in DEBUG mode");
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
