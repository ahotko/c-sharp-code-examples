using System;
using System.Collections.Concurrent;

namespace CodeSamples.UsefulClasses
{
    #region ObjectPool Class
    public class ObjectPool<T>
    {
        private ConcurrentBag<T> _objects;
        private Func<T> _objectGenerator;

        public ObjectPool(Func<T> objectGenerator)
        {
            if (objectGenerator == null) throw new ArgumentNullException("objectGenerator");
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator;
        }

        public T GetObject()
        {
            T item;
            if (_objects.TryTake(out item)) return item;
            return _objectGenerator();
        }

        public void PutObject(T item)
        {
            _objects.Add(item);
        }
    }
    #endregion

    #region Worker Class
    public class MyWorkerClass
    {
        public MyWorkerClass()
        {
            Console.WriteLine("Generated worker...");
        }

        public void DoSomething()
        {
            Console.WriteLine("...done something");
        }
    }
    #endregion

    public class ObjectPoolSample: SampleExecute
    {
        private ObjectPool<MyWorkerClass> _pool = new ObjectPool<MyWorkerClass>(() => new MyWorkerClass());

        public override void Execute()
        {
            Title($"ObjectPoolExecute");
            for(int i = 0; i < 5; i++)
            {
                //only 1 worker class will be created and then reused
                var worker = _pool.GetObject();
                worker.DoSomething();
                _pool.PutObject(worker);
            }
            Finish();
        }
    }
}
