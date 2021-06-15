using System;

namespace CodeSamples.Patterns.Structural
{
    public class FacadePatternSample : SampleExecute
    {

        internal class SubSystemOne
        {
            public void DoSomething()
            {
                Console.WriteLine("Doing Something");
            }
        }

        internal class SubSystemTwo
        {
            public void DoSomethingElse()
            {
                Console.WriteLine("Doing Something Else");
            }
        }

        internal class SubSystemThree
        {
            public void WriteABook()
            {
                Console.WriteLine("Writing a book");
            }
        }

        internal class SubSystemFour
        {
            public void Swim()
            {
                Console.WriteLine("Swimming");
            }
        }

        internal class FacadeClass
        {
            private readonly SubSystemOne _one = new SubSystemOne();
            private readonly SubSystemTwo _two = new SubSystemTwo();
            private readonly SubSystemThree _three = new SubSystemThree();
            private readonly SubSystemFour _four = new SubSystemFour();

            public void GoLeisureTimeMethodOne()
            {
                _one.DoSomething();
                _three.WriteABook();
                _four.Swim();
            }

            public void GoLeisureTimeAll()
            {
                _one.DoSomething();
                _two.DoSomethingElse();
                _three.WriteABook();
                _four.Swim();
            }
        }

        public override void Execute()
        {
            Section("Facade Pattern");
            var facade = new FacadeClass();

            facade.GoLeisureTimeMethodOne();
            Console.WriteLine();
            facade.GoLeisureTimeAll();
        }
    }
}
