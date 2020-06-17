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


        [StructLayout(LayoutKind.Explicit)]
        public struct FloatAndUint
        {
            [FieldOffset(0)]
            public float FloatValue;

            [FieldOffset(0)]
            public uint UintValue;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct DoubleAndUlong
        {
            [FieldOffset(0)]
            public double DoubleValue;

            [FieldOffset(0)]
            public ulong UlongValue;
        }

        [Flags]
        internal enum DosFileAttributes : byte
        {
            None = 0,
            ReadOnly = 1,
            Archive = 2,
            Compressed = 4,
            Hidden = 8,
            System = 16,
            Encrypted = 32,
            Indexed = 64,
            Temporary = 128
        }

        internal enum DosFileOwnership : byte
        {
            None = 0,
            User = 1,
            System = 2,
            Administrator = 3,
            Network = 4,
            Domain = 5,
            Creator = 6,
            Editor = 7
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct EnumInStruct
        {
            [FieldOffset(0)]
            public uint FileHeader;

            [FieldOffset(2)]
            public DosFileOwnership Ownership;

            [FieldOffset(3)]
            public DosFileAttributes Attributes;
        }

        public override void Execute()
        {
            Title("StructSampleExecute");

            Section("Compose bytes into int");
            var makeAnIntFromBytes = new FourBytesMakeAnInteger(0x11, 0x22, 0x33, 0x44);
            Console.WriteLine($"We have four bytes (0x{makeAnIntFromBytes.A:X2}, 0x{makeAnIntFromBytes.B:X2}, 0x{makeAnIntFromBytes.C:X2}, 0x{makeAnIntFromBytes.D:X2}), we composed them into an integer (0x{makeAnIntFromBytes.UnsignedInteger:X8}).");

            var makeBytesFromInt = new FourBytesMakeAnInteger(0xFFEEDDAA);
            Console.WriteLine($"We have an integer (0x{makeBytesFromInt.UnsignedInteger:X8}) we divided into four bytes (0x{makeBytesFromInt.A:X2}, 0x{makeBytesFromInt.B:X2}, 0x{makeBytesFromInt.C:X2}, 0x{makeBytesFromInt.D:X2}).");

            Section("Convert float to uint");
            var floatAndUint = new FloatAndUint();
            floatAndUint.FloatValue = 3.1415926f;
            Console.WriteLine($"We have an float ({floatAndUint.FloatValue}) we can show as uint (in hex) = (0x{floatAndUint.UintValue:X8}).");
            floatAndUint.UintValue = 0x40490fda;  //PI in IEEE-754 format
            Console.WriteLine($"We have an uint (in hex) = (0x{floatAndUint.UintValue:X8}) we can show as float = ({floatAndUint.FloatValue}).");

            Section("Convert double to ulong");
            var doubleAndUlong = new DoubleAndUlong();
            doubleAndUlong.DoubleValue = Math.E;
            Console.WriteLine($"We have an float ({doubleAndUlong.DoubleValue}) we can show as uint (in hex) = (0x{doubleAndUlong.UlongValue:X16}).");
            doubleAndUlong.UlongValue = 0x400921fb54442d18;  //PI in IEEE-754 format
            Console.WriteLine($"We have an uint (in hex) = (0x{doubleAndUlong.UlongValue:X16}) we can show as float = ({doubleAndUlong.DoubleValue}).");

            Section("Enum in struct");
            var random = new Random();
            byte attributes = (byte)random.Next(1, 255);
            byte ownership = (byte)(random.Next(1, 255) % 8);
            var enumInStruct = new EnumInStruct();
            enumInStruct.FileHeader = (uint)((attributes << 24) | (ownership << 16) | 0x5678);
            Console.WriteLine($"We have a FileHeader (in hex) = (0x{enumInStruct.FileHeader:X8}), we can extract Attributes = ({enumInStruct.Attributes.ToString("g")}) and ownership = ({enumInStruct.Ownership.ToString("g")}).");

            Finish();
        }
    }
}
