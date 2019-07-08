namespace CodeSamples.Patterns
{
    public class PatternsSample : SampleExecute
    {
        public override void Execute()
        {
            Title("PatternsSampleExecute");
            Section("Creational Patterns");
            var singleton = new SingletonPatternSample();
            singleton.Execute();
            LineBreak();
            Section("Behavioral Patterns");
            var strategy = new StrategyPatternSample();
            strategy.Execute();
            Finish();
        }
    }
}
