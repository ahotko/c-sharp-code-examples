using CodeSamples.Alterations;
using CodeSamples.Patterns;
using CodeSamples.SyntacticSugars;
using CodeSamples.TupleDeconstruction;
using CodeSamples.Useful;
using CodeSamples.UsefulClasses;
using System;

namespace CodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Code Samples";

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

            var usings = new UsingSample();
            usings.Execute();

            var interpol = new StringInterpolationSample();
            interpol.Execute();

            var patterns = new PatternMatchingSample();
            patterns.Execute();
            #endregion

            #region Useful
            var useful = new UsefulSample();
            useful.Execute();
            #endregion

            #region Patterns
            var patts = new PatternsSample();
            patts.Execute();
            #endregion

            #region LINQ
            var linqs = new LinqSample();
            linqs.Execute();
            #endregion

            #region Operators
            var opera = new OperatorOverloadingSample();
            opera.Execute();
            #endregion

            #region Entity Conversion
            var entityConv = new EntityConversionSample();
            entityConv.Execute();
            #endregion

            Console.WriteLine();
            Console.WriteLine("End Code Samples");

            Console.ReadKey();
        }
    }
}
