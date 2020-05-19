namespace CodeSamples.MultiThreading
{
    public class MultithreadingSample : SampleExecute
    {
        public override void Execute()
        {
            Title("MultithreadingSample");

            Section("BackgroundWorker is online...");
            var backgroundWorkerSample = new BackgroundWorkerSample();
            backgroundWorkerSample.Go();

            LineBreak();

            Section("Thread is online...");
            var threadSample = new ThreadSample();
            threadSample.Go();

            Finish();
        }
    }
}
