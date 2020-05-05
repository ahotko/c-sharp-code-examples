using System.Collections.Generic;

namespace CodeSamples.Comparing
{
    public class EqualityComparer : IEqualityComparer<EqualityComparerSample>
    {
        public bool Equals(EqualityComparerSample x, EqualityComparerSample y)
        {
            if (x is null && y is null) return true;
            if (x is null || y is null) return false;
            return (x.IntProperty == y.IntProperty && x.StringProperty == y.StringProperty);
        }

        public int GetHashCode(EqualityComparerSample obj)
        {
            return obj.IntProperty.GetHashCode() ^ obj.StringProperty.GetHashCode();
        }
    }

    public class EqualityComparerSample
    {
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }

        public override string ToString()
        {
            return $"Int = {IntProperty}, String = {StringProperty}";
        }
    }
}
