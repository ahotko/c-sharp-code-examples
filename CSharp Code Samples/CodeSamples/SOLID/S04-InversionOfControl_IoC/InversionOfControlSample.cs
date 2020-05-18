namespace CodeSamples.SOLID.S04_InversionOfControl_IoC
{
    public class InversionOfControlSample : SampleExecute
    {
        public override void Execute()
        {
            Title("SOLID - InversionOfControl");
            Section("Dependency Injection");

            var amazingDuck = new Duck(new FrenchQuack(), new JetFly());
            amazingDuck.Quack();
            amazingDuck.Fly();

            var weirdDuck = new Duck(new SpanishQuack(), new NormalFly());
            weirdDuck.Quack();
            weirdDuck.Fly();
        }
    }
}
