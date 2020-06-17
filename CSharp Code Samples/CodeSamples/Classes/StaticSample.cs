using System;

namespace CodeSamples.Classes
{
    internal static class StaticClass
    {
        static readonly int Constant = 10;

        static StaticClass()
        {
            Console.WriteLine($"Called static constructor of StaticClass, property {nameof(Constant)} = {Constant}");
        }

        public static void Something()
        {
            Console.WriteLine($"Something is going on...");
        }
    }

    internal class RegularClassWithStaticMethods
    {
        public RegularClassWithStaticMethods()
        {
            Console.WriteLine("Hey! You woke me up! What do you want? I'm just a regular constructor...");
        }

        /// <summary>
        /// Static constructor is only called once, even when instantiating a class
        /// </summary>
        static RegularClassWithStaticMethods()
        {
            Console.WriteLine("Hello! You have reached static constructor. How may I help you?");
        }

        public void RegularMethod()
        {
            Console.WriteLine("Meh! I'm just a regular method!");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Oh yeah! I'm a static method!");
        }
    }

    public class StaticSample : SampleExecute
    {
        public override void Execute()
        {
            Title("StaticSampleExecute");

            Section("Static Class");
            StaticClass.Something();

            Section("Regular Class, Regular method");
            var regularClass = new RegularClassWithStaticMethods();
            regularClass.RegularMethod();

            Section("Regular Class, Static method");
            RegularClassWithStaticMethods.StaticMethod();

            Finish();
        }
    }
}
