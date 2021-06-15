using System;

namespace CodeSamples.Patterns.Structural
{
    public class DecoratorPatternSample : SampleExecute
    {

        internal interface IBird
        {
            string Fly();
        }

        internal class Bird : IBird
        {
            public string Fly()
            {
                return "Flying";
            }
        }

        //decorator classes
        internal class FasterBird : IBird
        {
            protected readonly IBird _bird;

            public FasterBird(IBird bird)
            {
                _bird = bird;
            }

            public string Fly()
            {
                return $"{_bird.Fly()} faster";
            }
        }

        internal class FastestBird : IBird
        {
            protected readonly IBird _bird;

            public FastestBird(IBird bird)
            {
                _bird = bird;
            }

            public string Fly()
            {
                return $"{_bird.Fly()} like tail is on fire";
            }
        }

        public override void Execute()
        {
            Section("Decorator Pattern");
            var bird = new Bird();
            Console.WriteLine(bird.Fly());

            var fasterBird = new FasterBird(bird);
            Console.WriteLine(fasterBird.Fly());

            var fastestBird = new FastestBird(fasterBird);
            Console.WriteLine(fastestBird.Fly());
        }
    }
}
