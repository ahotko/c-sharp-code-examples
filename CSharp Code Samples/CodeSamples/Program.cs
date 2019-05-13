using CodeSamples.Patterns;
using CodeSamples.SyntacticSugars;
using CodeSamples.TupleDeconstruction;
using CodeSamples.Useful;
using CodeSamples.UsefulClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
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

            #region Properties
            var props = new PropertiesSample();
            props.Execute();
            #endregion

            #region Useful
            var useful = new UsefulSample();
            useful.Execute();
            #endregion

            #region Patterns
            var patts = new PatternsSample();
            patts.Execute();
            #endregion

            Console.ReadKey();
        }
    }
}
