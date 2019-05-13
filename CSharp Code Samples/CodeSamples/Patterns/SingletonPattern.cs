using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
