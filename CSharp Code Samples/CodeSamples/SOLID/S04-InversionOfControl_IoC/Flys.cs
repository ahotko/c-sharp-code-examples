using System;

namespace CodeSamples.SOLID.S04_InversionOfControl_IoC
{
    public class JetFly : IDuckFly
    {
        public void Fly()
        {
            Console.WriteLine("....zzzzzzzzz......I'm flying very fast! Jet fast!");
        }
    }

    public class NormalFly : IDuckFly
    {
        public void Fly()
        {
            Console.WriteLine("...quackin' my way in the clouds...");
        }
    }
}
