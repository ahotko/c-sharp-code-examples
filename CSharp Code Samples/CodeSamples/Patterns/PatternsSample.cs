using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Patterns
{
    public class PatternsSample : SampleExecute
    {
        public override void Execute()
        {
            Title("PatternsSampleExecute");
            SingletonPattern.Instance.SomeMethod();
            Finish();
        }
    }
}
