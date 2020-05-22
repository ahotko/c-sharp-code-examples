using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
/// </summary>
namespace CodeSamples.Classes
{
    #region Support stuff for Snippets
    internal enum EnumType
    {
        No,
        Yes
    }

    internal struct StructType
    {
        public string Something;
        public int SomethingElse;
    }

    internal class ClassWithParameterlessConstructor
    {
        public ClassWithParameterlessConstructor()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name}.");
        }
    }

    internal class ClassWithParameterConstructor
    {
        public ClassWithParameterConstructor(int count)
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name}.");
        }
    }

    internal interface ISomeInterface
    {
        void Go();
    }

    internal class ClassFromSomeInterface : ISomeInterface
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name}.");
        }
    }

    internal abstract class SomeBaseClass
    {
        public abstract void Go();
    }

    internal class SomeClassFromBaseClass : SomeBaseClass
    {
        public override void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name}.");
        }
    }
    #endregion

    internal class GenericClass<T>
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    /// <summary>
    /// The type argument must be a non-nullable value type. For information about 
    /// nullable value types, see Nullable value types. Because all value types have 
    /// an accessible parameterless constructor, the struct constraint implies the new() 
    /// constraint and can't be combined with the new() constraint. You can't combine 
    /// the struct constraint with the unmanaged constraint.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClassStruct<T> where T : struct
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    /// <summary>
    /// The type argument must be a reference type. This constraint applies also to any 
    /// class, interface, delegate, or array type. In a nullable context in C# 8.0 or 
    /// later, T must be a non-nullable reference type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClassClass<T> where T : class
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    /// <summary>
    /// The type argument must have a public parameterless constructor. When used together 
    /// with other constraints, the new() constraint must be specified last. The new() 
    /// constraint can't be combined with the struct and unmanaged constraints.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClassNew<T> where T : new()
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    /// <summary>
    /// The type argument must be a non-nullable unmanaged type. The unmanaged constraint 
    /// implies the struct constraint and can't be combined with either the struct or new() 
    /// constraints.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClassUnmanaged<T> where T : unmanaged
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    /// <summary>
    /// The type argument must be or derive from the specified base class. In a nullable context 
    /// in C# 8.0 and later, T must be a non-nullable reference type derived from the specified base class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClassBaseClass<T> where T : SomeBaseClass
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    /// <summary>
    /// The type argument must be or implement the specified interface. Multiple interface constraints 
    /// can be specified. The constraining interface can also be generic. In a nullable context in C# 8.0 
    /// and later, T must be a non-nullable type that implements the specified interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class GenericClassInterface<T> where T : ISomeInterface
    {
        public void Go()
        {
            Console.WriteLine($"Hello! I am {this.GetType().Name} and my main element is of type {typeof(T)}.");
        }
    }

    public class GenericsSample : SampleExecute
    {
        public override void Execute()
        {
            Title("GenericSampleExecute");

            var genericClass1 = new GenericClass<int>();
            genericClass1.Go();

            var genericClass2 = new GenericClass<string>();
            genericClass2.Go();

           var  genericClass3 = new GenericClass<EnumType>();
            genericClass3.Go();

            var genericClassEnum = new GenericClassStruct<EnumType>();
            genericClassEnum.Go();

            var genericClassStruct = new GenericClassStruct<StructType>();
            genericClassStruct.Go();

            var genericClassClass = new GenericClassClass<Collection<int>>();
            genericClassClass.Go();

            var genericClassNew = new GenericClassNew<ClassWithParameterlessConstructor>();
            genericClassNew.Go();

            //this producess error, because constructor has parameter:
            //Error CS0310  'ClassWithParameterConstructor' must be a non-abstract type with a 
            //public parameterless constructor in order to use it as parameter 'T' in the generic 
            //type or method 'GenericClassNew<T>'
            //var genericClassNewParam = new GenericClassNew<ClassWithParameterConstructor>();
            //genericClassNewParam.Go();

            var genericClassUnmanaged = new GenericClassUnmanaged<int>();
            genericClassUnmanaged.Go();

            //this producess error, because ClassWithParameterlessConstructor in not unmanaged type:
            ///Error CS8377  The type 'ClassWithParameterlessConstructor' must be a non-nullable 
            ///value type, along with all fields at any level of nesting, in order to use it as 
            ///parameter 'T' in the generic type or method 'GenericClassUnmanaged<T>'
            //var genericClassUnmanaged2 = new GenericClassUnmanaged<ClassWithParameterlessConstructor>();
            //genericClassUnmanaged2.Go();

            var genericClassInterface1 = new GenericClassInterface<ISomeInterface>();
            genericClassInterface1.Go();

            var genericClassInterface2 = new GenericClassInterface<ClassFromSomeInterface>();
            genericClassInterface2.Go();

            var genericClassBaseClass1 = new GenericClassBaseClass<SomeBaseClass>();
            genericClassBaseClass1.Go();

            var genericClassBaseClass2 = new GenericClassBaseClass<SomeClassFromBaseClass>();
            genericClassBaseClass2.Go();

            Finish();
        }
    }
}
