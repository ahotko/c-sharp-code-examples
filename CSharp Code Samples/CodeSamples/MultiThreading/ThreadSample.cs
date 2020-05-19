using System;
using System.Threading;

namespace CodeSamples.MultiThreading
{
    internal class LaborInstructions
    {
        private readonly AutoResetEvent _syncObject;

        public string SomeParameter { get; set; }

        public AutoResetEvent SyncObject => _syncObject;

        public LaborInstructions(AutoResetEvent syncObject)
        {
            _syncObject = syncObject;
        }
    }

    internal class ThreadLabor
    {
        public void DoWork(object instructions)
        {
            var passedParametersClass = instructions as LaborInstructions;
            Console.WriteLine($"Doing labor... {passedParametersClass.SomeParameter} ... and waiting to complete...");
            Thread.Sleep(1000);
            passedParametersClass.SyncObject.Set();
        }
    }

    public class ThreadSample
    {
        private readonly AutoResetEvent syncObject = new AutoResetEvent(false);

        public void Go()
        {
            var threadLabor = new ThreadLabor();
            var laborInstructions = new LaborInstructions(syncObject)
            {
                SomeParameter = $"Current DateTime is {DateTime.Now.ToString()}"
            };

            Console.WriteLine("Going into thread...");
            var thread = new Thread(threadLabor.DoWork)
            {
                Priority = ThreadPriority.Highest
            };
            thread.Start(laborInstructions);
            syncObject.WaitOne();
            Console.WriteLine("done!");
        }
    }
}
