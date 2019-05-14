using System;

namespace CodeSamples
{
    public abstract class SampleExecute : ISampleExecute
    {
        private ConsoleColor _oldForeColor;
        private ConsoleColor _oldBackColor;

        private void PushColors()
        {
            _oldForeColor = Console.ForegroundColor;
            _oldBackColor = Console.BackgroundColor;
        }

        private void PopColors()
        {
            Console.ForegroundColor = _oldForeColor;
            Console.BackgroundColor = _oldBackColor;
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
            PushColors();
            SetTitleColor();
            Console.WriteLine(title);
            PopColors();
            Console.WriteLine("============================================================");
        }

        public void Section(string title)
        {
            PushColors();
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
        public abstract void Execute();
    }
}
