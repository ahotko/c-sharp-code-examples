using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Alterations
{
    #region Calculation Class
    public class CalculationClass
    {
        public int A { get; set; }

        public static CalculationClass operator +(CalculationClass firstValue, CalculationClass secondValue)
        {
            var result = new CalculationClass();
            result.A = firstValue.A + secondValue.A;
            return result;
        }

        public static CalculationClass operator -(CalculationClass firstValue, CalculationClass secondValue)
        {
            var result = new CalculationClass();
            result.A = firstValue.A - secondValue.A;
            return result;
        }

        public static CalculationClass operator *(CalculationClass firstValue, CalculationClass secondValue)
        {
            var result = new CalculationClass();
            result.A = firstValue.A * secondValue.A;
            return result;
        }

        public static CalculationClass operator /(CalculationClass firstValue, CalculationClass secondValue)
        {
            var result = new CalculationClass();
            result.A = firstValue.A / secondValue.A;
            return result;
        }

        public static bool operator true(CalculationClass value)
        {
            return value.A != 0;
        }

        public static bool operator false(CalculationClass value)
        {
            return value.A == 0;
        }

        public static Boolean operator ==(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A == secondValue.A);
        }

        public static Boolean operator !=(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A != secondValue.A);
        }

        public override bool Equals(object obj)
        {
            var value = obj as CalculationClass;
            if (obj == null)
            {
                return false;
            }
            bool result = this.A == value.A;
            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return String.Format($"{this.A}");
        }
    }
    #endregion

    public class OperatorOverloadingSample : SampleExecute
    {
        public override void Execute()
        {
            Title("OperatorOverloadingSampleExecute");
            CalculationClass A = new CalculationClass() { A = 100 };
            CalculationClass B = new CalculationClass() { A = 3 };
            CalculationClass C = new CalculationClass() { A = 0 };
            var sum = A + B;
            var diff = A - B;
            var product = A * B;
            var coeff = A / B;
            var equal = A == B;
            var notEqual = A != B;
            //
            Console.WriteLine($"Original => A = {A}, B = {B}");
            Console.WriteLine($"Sum      => A + B  = {sum}");
            Console.WriteLine($"Diff     => A - B  = {diff}");
            Console.WriteLine($"Product  => A * B  = {product}");
            Console.WriteLine($"Coeff    => A / B  = {coeff}");
            Console.WriteLine($"Equal    => A == B = {equal}");
            Console.WriteLine($"notEqual => A != B = {notEqual}");
            Console.WriteLine($"true/false => A = {(A ? "true" : "false")}");
            Console.WriteLine($"true/false => B = {(B ? "true" : "false")}");
            Console.WriteLine($"true/false => C (=) = {(C ? "true" : "false")}");
            //
            Finish();
        }
    }
}
