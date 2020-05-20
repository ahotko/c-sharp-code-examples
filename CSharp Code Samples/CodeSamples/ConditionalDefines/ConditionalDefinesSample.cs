namespace CodeSamples.ConditionalDefines
{
    public class ConditionalDefinesSample : SampleExecute
    {
        public override void Execute()
        {
            Title("ConditionalDefinesSampleExecute");

            //for these comments see "Task List" Tab below

            //TODO Todo comment for Task List; this should be done asap

            //HACK Hack comment for Task List; Ugly hack...repair later

            //UNDONE Undone comment for Task List; Something was broken

            Section(".NET Framework");

#if NETFRAMEWORK
            Console.WriteLine("NETFRAMEWORK");
#endif
#if NET20
            Console.WriteLine("NET20");
#elif NET35
            Console.WriteLine("NET35");
#elif NET40
            Console.WriteLine("NET40");
#elif NET45
            Console.WriteLine("NET45");
#elif NET451
            Console.WriteLine("NET451");
#elif NET452
            Console.WriteLine("NET452");
#elif NET46
            Console.WriteLine("NET46");
#elif NET461
            Console.WriteLine("NET461");
#elif NET462
            Console.WriteLine("NET462");
#elif NET47
            Console.WriteLine("NET47");
#elif NET471
            Console.WriteLine("NET471");
#elif NET472
            Console.WriteLine("NET472");
#elif NET48
            Console.WriteLine("NET48");
#endif

            Section(".NET Standard");
#if NETSTANDARD
            Console.WriteLine("NETSTANDARD");
#endif
#if NETSTANDARD1_0
            Console.WriteLine("NETSTANDARD1_0");
#elif NETSTANDARD1_1
            Console.WriteLine("NETSTANDARD1_1");
#elif NETSTANDARD1_2
            Console.WriteLine("NETSTANDARD1_2");
#elif NETSTANDARD1_3
            Console.WriteLine("NETSTANDARD1_3");
#elif NETSTANDARD1_4
            Console.WriteLine("NETSTANDARD1_4");
#elif NETSTANDARD1_5
            Console.WriteLine("NETSTANDARD1_5");
#elif NETSTANDARD1_6
            Console.WriteLine("NETSTANDARD1_6");
#elif NETSTANDARD2_0
            Console.WriteLine("NETSTANDARD2_0");
#elif NETSTANDARD2_1
            Console.WriteLine("NETSTANDARD2_1");
#endif

            Section(".NET Core");
#if NETCOREAPP
            Console.WriteLine("NETCOREAPP");
#endif
#if NETCOREAPP1_0
            Console.WriteLine("NETCOREAPP1_0");
#elif NETCOREAPP1_1
            Console.WriteLine("NETCOREAPP1_1");
#elif NETCOREAPP2_0
            Console.WriteLine("NETCOREAPP2_0");
#elif NETCOREAPP2_1
            Console.WriteLine("NETCOREAPP2_1");
#elif NETCOREAPP2_2
            Console.WriteLine("NETCOREAPP2_2");
#elif NETCOREAPP3_0
            Console.WriteLine("NETCOREAPP3_0");
#elif NETCOREAPP3_1
            Console.WriteLine("NETCOREAPP3_1");
#endif

            Finish();
        }
    }
}
