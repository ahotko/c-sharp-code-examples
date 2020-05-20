using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.ConditionalDefines
{
    public class ConditionalDefinesSample : SampleExecute
    {
        public override void Execute()
        {
            Title("ConditionalDefinesSampleExecute");

            Section(".NET Framework");
#if NETFRAMEWORK
            Console.WriteLine("NETFRAMEWORK");
#endif
#if NET20
            Console.WriteLine("NET20");
#endif
#if NET35
            Console.WriteLine("NET35");
#endif
#if NET40
            Console.WriteLine("NET40");
#endif
#if NET45
            Console.WriteLine("NET45");
#endif
#if NET451
            Console.WriteLine("NET451");
#endif
#if NET452
            Console.WriteLine("NET452");
#endif
#if NET46
            Console.WriteLine("NET46");
#endif
#if NET461
            Console.WriteLine("NET461");
#endif
#if NET462
            Console.WriteLine("NET462");
#endif
#if NET47
            Console.WriteLine("NET47");
#endif
#if NET471
            Console.WriteLine("NET471");
#endif
#if NET472
            Console.WriteLine("NET472");
#endif
#if NET48
            Console.WriteLine("NET48");
#endif

            Section(".NET Standard");
#if NETSTANDARD
            Console.WriteLine("NETSTANDARD");
#endif
#if NETSTANDARD1_0
            Console.WriteLine("NETSTANDARD1_0");
#endif
#if NETSTANDARD1_1
            Console.WriteLine("NETSTANDARD1_1");
#endif
#if NETSTANDARD1_2
            Console.WriteLine("NETSTANDARD1_2");
#endif
#if NETSTANDARD1_3
            Console.WriteLine("NETSTANDARD1_3");
#endif
#if NETSTANDARD1_4
            Console.WriteLine("NETSTANDARD1_4");
#endif
#if NETSTANDARD1_5
            Console.WriteLine("NETSTANDARD1_5");
#endif
#if NETSTANDARD1_6
            Console.WriteLine("NETSTANDARD1_6");
#endif
#if NETSTANDARD2_0
            Console.WriteLine("NETSTANDARD2_0");
#endif
#if NETSTANDARD2_1
            Console.WriteLine("NETSTANDARD2_1");
#endif

            Section(".NET Core");
#if NETCOREAPP
            Console.WriteLine("NETCOREAPP");
#endif
#if NETCOREAPP1_0
            Console.WriteLine("NETCOREAPP1_0");
#endif
#if NETCOREAPP1_1
            Console.WriteLine("NETCOREAPP1_1");
#endif
#if NETCOREAPP2_0
            Console.WriteLine("NETCOREAPP2_0");
#endif
#if NETCOREAPP2_1
            Console.WriteLine("NETCOREAPP2_1");
#endif
#if NETCOREAPP2_2
            Console.WriteLine("NETCOREAPP2_2");
#endif
#if NETCOREAPP3_0
            Console.WriteLine("NETCOREAPP3_0");
#endif
#if NETCOREAPP3_1
            Console.WriteLine("NETCOREAPP3_1");
#endif

            Finish();
        }
    }
}
