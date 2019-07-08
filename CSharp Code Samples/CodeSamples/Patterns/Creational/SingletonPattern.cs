using System;

namespace CodeSamples.Patterns.Creational
{
    public class SingletonPattern
    {
        #region Singleton
        static readonly SingletonPattern _instance = new SingletonPattern();
        public static SingletonPattern Instance { get { return _instance; } }
        #endregion

        public void SomeMethod()
        {
            Console.WriteLine("Singleton method called");
        }

        public void SomeOtherMethod()
        {
            Console.WriteLine("Singleton other method called");
        }
    }

    public class SingletonPatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("Singleton Pattern");
            SingletonPattern.Instance.SomeMethod();
            SingletonPattern.Instance.SomeOtherMethod();
        }
    }
}
