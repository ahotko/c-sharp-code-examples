using System;

namespace CodeSamples.Comparing
{
    public sealed class EquatableSample : IEquatable<EquatableSample>
    {
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }

        public bool Equals(EquatableSample other)
        {
            if (other is null) return false;
            return (other.IntProperty == IntProperty && other.StringProperty == StringProperty);
        }

        public override string ToString()
        {
            return $"Int = {IntProperty}, String = {StringProperty}";
        }
    }
}
