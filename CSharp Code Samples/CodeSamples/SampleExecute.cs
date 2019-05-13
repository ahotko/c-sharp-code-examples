using System;

namespace CodeSamples
{
    public abstract class SampleExecute : ISampleExecute
    {
        public void Title(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("============================================================");
        }

        public void Finish()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        //from interface
        public abstract void Execute();
    }
}
