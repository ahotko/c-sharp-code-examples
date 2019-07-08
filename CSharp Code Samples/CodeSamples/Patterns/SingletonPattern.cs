using System;

namespace CodeSamples.Patterns
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
    }

    public class SingletonPatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("Singleton Pattern");
            SingletonPattern.Instance.SomeMethod();
        }
    }
}
