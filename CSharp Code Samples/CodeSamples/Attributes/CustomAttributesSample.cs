using System;

namespace CodeSamples.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class DefaultValueAttribute : Attribute
    {
        private int _defaultValue;

        public DefaultValueAttribute(int defaultValue)
        {
            _defaultValue = defaultValue;
        }
    }


    public class CustomAttributesSample
    {
        [DefaultValue(5)]
        public int SomeProperty { get; set; }
    }
}
