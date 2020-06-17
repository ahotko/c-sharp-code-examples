using System;
using System.Runtime.InteropServices;

namespace CodeSamples.Structures
{
    public class StructSample : SampleExecute
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct FourBytesMakeAnInteger
        {

            public FourBytesMakeAnInteger(uint unsignedInteger)
            {
                A = 0;
                B = 0;
                C = 0;
                D = 0;
                UnsignedInteger = unsignedInteger;
            }

            public FourBytesMakeAnInteger(byte a, byte b, byte c, byte d)
            {
                UnsignedInteger = 0;
                A = a;
                B = b;
                C = c;
                D = d;
            }

            [FieldOffset(0)]
            public readonly byte A;

            [FieldOffset(1)]
            public readonly byte B;

            [FieldOffset(2)]
            public readonly byte C;

            [FieldOffset(3)]
            public readonly byte D;

            [FieldOffset(0)] 
            public readonly uint UnsignedInteger;
        }

        public override void Execute()
        {
            Title("FilesSampleExecute");

            var makeAnIntFromBytes = new FourBytesMakeAnInteger(0x11, 0x22, 0x33, 0x44);
            Console.WriteLine($"We have four bytes (0x{makeAnIntFromBytes.A:X2}, 0x{makeAnIntFromBytes.B:X2}, 0x{makeAnIntFromBytes.C:X2}, 0x{makeAnIntFromBytes.D:X2}), we composed them into an integer (0x{makeAnIntFromBytes.UnsignedInteger:X8}).");

            var makeBytesFromInt = new FourBytesMakeAnInteger(0xFFEEDDAA);
            Console.WriteLine($"We have an integer (0x{makeBytesFromInt.UnsignedInteger:X8}) we divided into four bytes (0x{makeBytesFromInt.A:X2}, 0x{makeBytesFromInt.B:X2}, 0x{makeBytesFromInt.C:X2}, 0x{makeBytesFromInt.D:X2}).");

            Finish();
        }
    }
}
