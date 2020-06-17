using CodeSamples.Alterations;
using CodeSamples.Attributes;
using CodeSamples.Classes;
using CodeSamples.Comparing;
using CodeSamples.ConditionalDefines;
using CodeSamples.Enums;
using CodeSamples.Exceptions;
using CodeSamples.Files;
using CodeSamples.MultiThreading;
using CodeSamples.Patterns;
using CodeSamples.Settings;
using CodeSamples.SOLID.S01_SingleResponsibilityPrinciple_SRP;
using CodeSamples.SOLID.S04_InversionOfControl_IoC;
using CodeSamples.Structures;
using CodeSamples.SyntacticSugars;
using CodeSamples.Timing;
using CodeSamples.TupleDeconstruction;
using CodeSamples.Useful;
using CodeSamples.UsefulClasses;
using System;

namespace CodeSamples
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Code Samples";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Start Code Samples");
            Console.WriteLine();

            #region Tuple Deconstruction
            var tupleDecon = new TupleDeconstructionSample();
            tupleDecon.Execute();
            #endregion

            #region Dictionaries
            var dics = new DictionariesSample();
            dics.Execute();
            #endregion

            #region Object Pool
            var objectPool = new ObjectPoolSample();
            objectPool.Execute();
            #endregion

            #region Syntactic Sugars
            var props = new PropertiesSample();
            props.Execute();

            var Sample = new UsingSample();
            Sample.Execute();

            var stringInterpolation = new StringInterpolationSample();
            stringInterpolation.Execute();

            var patternMatchingSample = new PatternMatchingSample();
            patternMatchingSample.Execute();

            var nullSample = new NullSample();
            nullSample.Execute();
            #endregion

            #region Useful
            var classAndMethodNamesSample = new ClassAndMethodNamesSample();
            classAndMethodNamesSample.Execute();

            var callerInfo = new CallerInfoSample();
            callerInfo.Execute();
            #endregion

            #region Patterns
            var patternsSample = new PatternsSample();
            patternsSample.Execute();
            #endregion

            #region LINQ
            var linqSample = new LinqSample();
            linqSample.Execute();
            #endregion

            #region Operators
            var operatorOverloadingSample = new OperatorOverloadingSample();
            operatorOverloadingSample.Execute();
            #endregion

            #region Entity Conversion
            var entityConversionSample = new EntityConversionSample();
            entityConversionSample.Execute();
            #endregion

            #region Classes
            var constructorChainingSample = new ConstructorChainingSample();
            constructorChainingSample.Execute();

            var anonymousTypesSample = new AnonymousTypesSample();
            anonymousTypesSample.Execute();
            #endregion

            #region Attributes
            var debuggerAttributeSample = new DebuggingSample();
            debuggerAttributeSample.Execute();

            var obsoleteAttributeSample = new ObsoleteSample();
            obsoleteAttributeSample.Execute();

            var conditionalAttributeSample = new ConditionalSample();
            conditionalAttributeSample.Execute();
            #endregion

            #region Threading
            var multithreadingSample = new MultithreadingSample();
            multithreadingSample.Execute();
            #endregion

            #region Equality
            var compareSample = new CompareSample();
            compareSample.Execute();
            #endregion

            #region SOLID
            var solidSrp = new SingleResponsibilityPrincipleSample();
            solidSrp.Execute();

            var solidIoC = new InversionOfControlSample();
            solidIoC.Execute();
            #endregion

            #region Timing
            var timingSample = new TimingSample();
            timingSample.Execute();
            #endregion

            #region Garbage Collection
            var gcSample = new GarbageCollectionSample();
            gcSample.Execute();
            #endregion

            #region Class Extensions
            var classExtensionSample = new ClassExtensionSample();
            classExtensionSample.Execute();
            #endregion

            #region Conditional defines
            var conditionalDefinesSample = new ConditionalDefinesSample();
            conditionalDefinesSample.Execute();
            #endregion

            #region Enums
            var enumSample = new EnumSample();
            enumSample.Execute();
            #endregion

            #region Arithmetic Overflow
            var overflowCheckSample = new OverflowCheckSample();
            overflowCheckSample.Execute();
            #endregion

            #region Generics
            var genericsSample = new GenericsSample();
            genericsSample.Execute();
            #endregion

            #region Exceptions
            var exceptionsSample = new ExceptionsSample();
            exceptionsSample.Execute();
            #endregion

            #region Settings
            var settingsSample = new SettingsSample();
            settingsSample.Execute();
            #endregion

            #region Files
            var filesSample = new FilesSample();
            filesSample.Execute();
            #endregion

            #region Struct
            var structSample = new StructSample();
            structSample.Execute();
            #endregion

            Console.WriteLine();
            Console.WriteLine("End Code Samples");

            Console.ReadKey();
        }
    }
}
