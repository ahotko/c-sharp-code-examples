using System;

namespace CodeSamples
{
    public abstract class SampleExecute : ISampleExecute
    {
        private void PopColors()
        {
            Console.ResetColor();
        }

        private void SetTitleColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private void SetSectionColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Title(string title)
        {
            SetTitleColor();
            Console.WriteLine();
            Console.WriteLine(title);
            PopColors();
            Console.WriteLine("============================================================");
        }

        public void Section(string title)
        {
            SetSectionColor();
            Console.WriteLine(title);
            PopColors();
            Console.WriteLine("============================================================");
        }

        public void LineBreak()
        {
            Console.WriteLine("============================================================");
        }

        public void Finish()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        //from interface
        //abstract methods MUST be implemented by derived class, because
        //they do not have implementation in abstract class
        public abstract void Execute();

        //virtual methods do not have to be implemented by derived class, because
        //they have implementation in abstract class; they can be overriden in derived
        //class, if necessary
        public virtual void ExecuteVirtual()
        {
            Console.WriteLine("Executing Virtual Method in abstract class");
        }

        //methods, that are not abstract or virtual, cannot be overriden in derived
        //class
        public void ExecuteNormal()
        {
            Console.WriteLine("Executing Method in abstract class");
        }
    }
}
