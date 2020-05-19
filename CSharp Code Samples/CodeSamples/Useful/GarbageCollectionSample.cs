using System;
using System.Threading;

/// <summary>
/// System.Runtime.GCLatencyMode.SustainedLowLatency
/// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.gclatencymode?view=netcore-3.1
/// 
/// Batch                 Disables garbage collection concurrency and reclaims
///                       objects in a batch call. This is the most intrusive mode.
/// 					  This mode is designed for maximum throughput at the
/// 					  expense of responsiveness.
/// 
/// Interactive           Enables garbage collection concurrency and reclaims
///                       objects while the application is running. This is
/// 					  the default mode for garbage collection on a
/// 					  workstation and is less intrusive than Batch.
/// 					  It balances responsiveness with throughput. This
/// 					  mode is equivalent to garbage collection on a
/// 					  workstation that is concurrent.
/// 
/// LowLatency            Enables garbage collection that is more conservative
///                       in reclaiming objects. Full collections occur only
/// 					  if the system is under memory pressure, whereas
/// 					  generation 0 and generation 1 collections might occur
/// 					  more frequently. This mode is not available for the
/// 					  server garbage collector.
/// 
/// NoGCRegion            Indicates that garbage collection is suspended while 
///                       the app is executing a critical path.
///                       NoGCRegion is a read-only value; that is, you cannot
/// 					  assign the NoGCRegion value to the LatencyMode property.
/// 					  You specify the no GC region latency mode by calling the
/// 					  TryStartNoGCRegion method and terminate it by calling the
/// 					  EndNoGCRegion() method.
/// 
/// SustainedLowLatency   Enables garbage collection that tries to minimize latency
///                       over an extended period. The collector tries to perform
/// 					  only generation 0, generation 1, and concurrent
/// 					  generation 2 collections. Full blocking collections may 
/// 					  still occur if the system is under memory pressure.
/// </summary>

namespace CodeSamples.Useful
{
    internal class GarbageCollectionInfo
    {
        public int MaxGeneration { get; private set; }

        public int Generation0 { get; private set; }
        public int Generation1 { get; private set; }
        public int Generation2 { get; private set; }

        public long TotalMemory { get; private set; }

        public GarbageCollectionInfo()
        {
            MaxGeneration = GC.MaxGeneration;

            Generation0 = GC.CollectionCount(0);
            Generation1 = GC.CollectionCount(1);
            Generation2 = GC.CollectionCount(2);

            TotalMemory = GC.GetTotalMemory(false);
        }

        public override string ToString()
        {
            return $"GC Info: MaxGen={MaxGeneration}, Gen0={Generation0}, Gen1={Generation1}, Gen2={Generation2}, Total Memory={TotalMemory}";
        }
    }

    internal class GarbageCollection
    {
#pragma warning disable S1481
        private void MakeSomeGarbage()
        {
            Console.WriteLine("Making Garbage...");
            for (int i = 0; i < 5000; i++)
            {
                var version = new Version();
            }
        }
#pragma warning restore S1481

#pragma warning disable S1215
        private void ForceGarbageCollection()
        {
            var gc = new GarbageCollection();

            var gcBefore = new GarbageCollectionInfo();
            Console.WriteLine($"Before Garbage Collection: {gcBefore}");
            gc.MakeSomeGarbage();
            var gcAfterGeneratingGarbage = new GarbageCollectionInfo();
            Console.WriteLine($"After Generating Garbage: {gcAfterGeneratingGarbage}");

            GC.Collect(0);
            var gcAfterCleanupGen0 = new GarbageCollectionInfo();
            Console.WriteLine($"After Garbage Collection of Gen0: {gcAfterCleanupGen0}");

            GC.Collect(1);
            var gcAfterCleanupGen1 = new GarbageCollectionInfo();
            Console.WriteLine($"After Garbage Collection of Gen1: {gcAfterCleanupGen1}");

            GC.WaitForPendingFinalizers();
            GC.Collect(2);

            var gcAfterCleanupGen2 = new GarbageCollectionInfo();
            Console.WriteLine($"After Garbage Collection of Gen2: {gcAfterCleanupGen2}");

            GC.WaitForPendingFinalizers();
            GC.Collect();

            var gcAfterCleanup = new GarbageCollectionInfo();
            Console.WriteLine($"After Garbage Collection: {gcAfterCleanup}");
        }
#pragma warning restore S1215

        private void TurnGarbageCollectionOff()
        {
            Console.Write("Turning Garbage Collection into low latency (= off)...");
            System.Runtime.GCSettings.LatencyMode = System.Runtime.GCLatencyMode.SustainedLowLatency;
            Console.WriteLine("done!");
        }

        private void TurnGarbageCollectionOn()
        {
            Console.Write("Turning Garbage Collection into interactive (= on)...");
            System.Runtime.GCSettings.LatencyMode = System.Runtime.GCLatencyMode.Interactive;
            Console.WriteLine("done!");
        }

        public void Go()
        {
            TurnGarbageCollectionOff();
            Thread.Sleep(1000);
            TurnGarbageCollectionOn();

            ForceGarbageCollection();
        }
    }

    public class GarbageCollectionSample : SampleExecute
    {
        public override void Execute()
        {
            Title("GarbageCollectionSample");

            var garbageCollection = new GarbageCollection();
            garbageCollection.Go();

            Finish();
        }
    }
}
