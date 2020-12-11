using System;

namespace CodeSamples.Classes
{
    public class SampleClass
    {
        public SampleClass() : this(0) { Console.WriteLine("Default Constructor"); }
        public SampleClass(int param) : this(0, "string param") { Console.WriteLine("Constructor with one parameter"); }
        public SampleClass(int paramInt, string paramStr) { Console.WriteLine("Constructor with two parameters"); }
    }

    public class ConstructorChainingSample : SampleExecute
    {
        public override void Execute()
        {
            Title("ConstructorChainingSampleExecute");
            Section("Creating class by calling constructor with no params");
            SampleClass classNoParams = new SampleClass();
            LineBreak();
            //
            Section("Creating class by calling constructor with 1 params");
            SampleClass classOneParam = new SampleClass(1);
            LineBreak();
            //
            Section("Creating class by calling constructor with 2 params");
            SampleClass classTwoParams = new SampleClass(3, "Yo! This is a story all about how...");
            //
            Finish();

            // Output:
            //
            // ConstructorChainingSampleExecute
            // ============================================================
            // Creating class by calling constructor with no params
            // ============================================================
            // Constructor with two parameters
            // Constructor with one parameter
            // Default Constructor
            // ============================================================
            // Creating class by calling constructor with 1 params
            // ============================================================
            // Constructor with two parameters
            // Constructor with one parameter
            // ============================================================
            // Creating class by calling constructor with 2 params
            // ============================================================
            // Constructor with two parameters
            // ============================================================
        }
    }
}
