using System;

namespace CodeSamples.Alterations
{
    #region Calculation Class
    /// <summary>
    /// List of overloadable operators: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
    /// </summary>
    public class CalculationClass
    {
        public int A { get; set; }

        #region Constructors
        public CalculationClass() : this(0) { }

        public CalculationClass(int initialValue)
        {
            A = initialValue;
        }
        #endregion

        #region Addition (Operator +)
        public static CalculationClass operator +(CalculationClass value) => value;

        public static CalculationClass operator +(CalculationClass firstValue, CalculationClass secondValue)
        {
            return new CalculationClass(firstValue.A + secondValue.A);
        }

        public static CalculationClass operator +(CalculationClass firstValue, int secondValue)
        {
            return firstValue + new CalculationClass(secondValue);
        }

        public static CalculationClass operator +(int firstValue, CalculationClass secondValue)
        {
            return secondValue + new CalculationClass(firstValue);
        }
        #endregion

        #region Subtraction (Operator -)
        public static CalculationClass operator -(CalculationClass value) => new CalculationClass(-value.A);

        public static CalculationClass operator -(CalculationClass firstValue, CalculationClass secondValue)
        {
            return new CalculationClass(firstValue.A - secondValue.A);
        }
        #endregion

        public static CalculationClass operator *(CalculationClass firstValue, CalculationClass secondValue)
        {
            return new CalculationClass(firstValue.A * secondValue.A);
        }

        public static CalculationClass operator /(CalculationClass firstValue, CalculationClass secondValue)
        {
            return new CalculationClass(firstValue.A / secondValue.A);
        }

        public static bool operator true(CalculationClass value)
        {
            return value.A != 0;
        }

        public static bool operator false(CalculationClass value)
        {
            return value.A == 0;
        }

        #region Equality
        public static Boolean operator ==(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A == secondValue.A);
        }

        public static Boolean operator !=(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A != secondValue.A);
        }
        #endregion

        #region Comparing

        #region Operator >
        public static Boolean operator >(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A > secondValue.A);
        }

        public static Boolean operator >(CalculationClass firstValue, int secondValue)
        {
            return (firstValue.A > secondValue);
        }

        public static Boolean operator >(int firstValue, CalculationClass secondValue)
        {
            return (firstValue > secondValue.A);
        }
        #endregion

        #region Operator <
        public static Boolean operator <(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A < secondValue.A);
        }

        public static Boolean operator <(CalculationClass firstValue, int secondValue)
        {
            return (firstValue.A < secondValue);
        }

        public static Boolean operator <(int firstValue, CalculationClass secondValue)
        {
            return (firstValue < secondValue.A);
        }
        #endregion

        #region Operator >=
        public static Boolean operator >=(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A >= secondValue.A);
        }
        #endregion

        #region Operator <=
        public static Boolean operator <=(CalculationClass firstValue, CalculationClass secondValue)
        {
            return (firstValue.A <= secondValue.A);
        }
        #endregion

        #endregion

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
