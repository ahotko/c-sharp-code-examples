using System;

namespace CodeSamples.SOLID.S04_InversionOfControl_IoC
{
    public class FrenchQuack : IDuckQuack
    {
        public void Quack()
        {
            Console.WriteLine("Le Quack!");
        }
    }

    public class SpanishQuack : IDuckQuack
    {
        public void Quack()
        {
            Console.WriteLine("Il Quacko!");
        }
    }
}
