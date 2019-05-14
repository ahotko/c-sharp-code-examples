using System;

namespace CodeSamples.SyntacticSugars
{
    public class MyDisposableClass : IDisposable
    {
        public void DoSomeStuff()
        {
            Console.WriteLine("...doing stuff");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }

    public class UsingSample : SampleExecute
    {

        public override void Execute()
        {
            Title("UsingSampleExecute");
            /* with "using" the code below is the same as:
             * var myDisposable = new MyDisposable();
             * try
             * {
             *   myDisposable.DoThing();
             * }
             * finally
             * {
             *   if (myDisposable != null)
             *   {
             *     ((IDisposable)myDisposable).Dispose();
             *   }
             * }
             */
            using (var myDisposable = new MyDisposableClass())
            {
                myDisposable.DoSomeStuff();
            }
            Finish();
        }
    }
}
