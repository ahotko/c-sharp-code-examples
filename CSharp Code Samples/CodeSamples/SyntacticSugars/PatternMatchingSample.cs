using System;

namespace CodeSamples.SyntacticSugars
{
    #region Test Classes
    public class Cat
    {
        public bool HasClaws => true;

        public void Voice()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dog
    {
        public bool Bites => true;

        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
    #endregion

    public class PatternMatchingSample : SampleExecute
    {
        private void DecideWhoIsIt(object obj)
        {
            switch(obj)
            {
                case Cat cat:
                    cat.Voice();
                    break;
                case Dog dog when dog.Bites:
                    dog.Bark();
                    break;
                case Duck duck:
                    duck.Quack();
                    break;
                default:
                    break;
            }
        }

        public override void Execute()
        {
            Title("PatternMatchingSampleExecute");
            DecideWhoIsIt(new Cat());
            DecideWhoIsIt(new Dog());
            DecideWhoIsIt(new Duck());
            Finish();
        }
    }
}
