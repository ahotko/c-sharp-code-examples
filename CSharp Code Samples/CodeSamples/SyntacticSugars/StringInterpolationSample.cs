using System;
using System.Text;

namespace CodeSamples.SyntacticSugars
{
    public class StringInterpolationSample : SampleExecute
    {
        public override void Execute()
        {
            Title("StringInterpolationSampleExecute");
            int intVariable = 5;
            string stringVariable = "some value";
            double doubleVariable = Math.PI;
            DateTime datetimeVariable = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            //
            sb.Append($"Integer = {intVariable}").Append(", ");
            sb.Append($"String = {stringVariable}").Append(", ");
            sb.Append($"Double (2 decimals) value = {doubleVariable:0.00}").Append(", ");
            sb.Append($"Double (2 decimals, leading zeroes) value = {doubleVariable:000.00}").Append(", ");
            sb.Append($"Double (5 decimals) = {doubleVariable:0.00000}").Append(", ");
            sb.Append($"DateTime (dd.MM.yyyy) = {datetimeVariable:dd.MM.yyyy}").Append(", ");
            sb.Append($"DateTime (yyyy-MM-dd) = {datetimeVariable:yyyy-MM-dd}");
            //
            Console.WriteLine(sb.ToString());
            Finish();
        }
    }
}
