using System;

namespace CodeSamples.SyntacticSugars
{
    public class PropertiesSample: SampleExecute
    {
        #region Property Assignment
        private string _propertyName = "value";

        //property getters/setter
        public string PropertyNameLong
        {
            get
            {
                return _propertyName;
            }
            set
            {
                _propertyName = value;
            }
        }

        //property short
        public string PropertyNameShort
        {
            get => _propertyName;
            set => _propertyName = value;
        }
        #endregion

        public string AutoProperty { get; set; }
        public string AutoPropertyDefaultValueEmpty { get; set; } = String.Empty;
        public string AutoPropertyDefaultValueNotEmpty { get; set; } = "default property value";

        public override void Execute()
        {
            Title("PropertiesExecute");
            Console.WriteLine($"PropertyNameLong = {PropertyNameLong}");
            Console.WriteLine($"PropertyNameShort = {PropertyNameShort}");
            Console.WriteLine($"AutoProperty = {AutoProperty}");
            Console.WriteLine($"AutoPropertyDefaultValueEmpty = {AutoPropertyDefaultValueEmpty}");
            Console.WriteLine($"AutoPropertyDefaultValueNotEmpty = {AutoPropertyDefaultValueNotEmpty}");
            Finish();
        }
    }
}
