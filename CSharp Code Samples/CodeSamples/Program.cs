using CodeSamples.TupleDeconstruction;
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
            tupleDecon.TupleDeconstructionExecute();
            #endregion

            #region Dictionaries
            var dics = new DictionariesSample();
            dics.DictionariesExecute();
            #endregion

            #region Object Pool
            var objectPool = new ObjectPoolSample();
            objectPool.ObjectPoolExecute();
            #endregion

            Console.ReadKey();
        }
    }
}
