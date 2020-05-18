using System;
using System.Diagnostics;
using System.Threading;

namespace CodeSamples.Timing
{
    public class TimingStopwatch
    {
        private void StopwatchSampleCreateManually()
        {
            var stopWatch = new Stopwatch();

            Console.Write("Going to sleep for a while, tired b/c of manual labor...");
            stopWatch.Start();
            Thread.Sleep(2000);
            stopWatch.Stop();
            Console.WriteLine($"woke up after {stopWatch.Elapsed}, that is {stopWatch.Elapsed.TotalMilliseconds} ms.");
        }

        private void StopwatchSampleCreateAuto()
        {

            Console.Write("Going to sleep for a while, tired b/c of auto create...");
            var stopWatch = Stopwatch.StartNew();
            Thread.Sleep(2000);
            stopWatch.Stop();
            Console.WriteLine($"woke up after {stopWatch.Elapsed}, that is {stopWatch.Elapsed.TotalMilliseconds} ms.");
        }

        public void Go()
        {
            StopwatchSampleCreateManually();
            StopwatchSampleCreateAuto();
        }
    }
}
