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
    public class GarbageCollectionSample : SampleExecute
    {
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

        public override void Execute()
        {
            Title("GarbageCollectionSample");
            TurnGarbageCollectionOff();
            Thread.Sleep(1000);
            TurnGarbageCollectionOn();

            Finish();
        }
    }
}
