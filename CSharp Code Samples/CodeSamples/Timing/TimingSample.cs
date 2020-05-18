namespace CodeSamples.Timing
{
    public class TimingSample : SampleExecute
    {
        public override void Execute()
        {
            Title("TimingSample");
            Section("Stopwatch Timing");

            var stopwatchTiming = new TimingStopwatch();
            stopwatchTiming.Go();

            Finish();
        }
    }
}
