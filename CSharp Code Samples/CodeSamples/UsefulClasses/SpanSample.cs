using System;

namespace CodeSamples.UsefulClasses
{
    public class SpanSample : SampleExecute
    {
        private void SpanOverArray()
        {
            //var arrayOfInt = new int[100];
            //var span = new Span<int>(arrayOfInt);

            //byte data = 0;
            //for (int ctr = 0; ctr < arraySpan.Length; ctr++)
            //    arraySpan[ctr] = data++;
        }

        private void SpanOverNativeMemory()
        {
            //var native = Marshal.AllocHGlobal(100);
            //Span<byte> nativeSpan;
            //unsafe
            //{
            //    nativeSpan = new Span<byte>(native.ToPointer(), 100);
            //}
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
