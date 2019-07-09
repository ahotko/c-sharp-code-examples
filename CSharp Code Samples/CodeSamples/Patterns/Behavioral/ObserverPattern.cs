using System;
using System.Collections.Generic;

namespace CodeSamples.Patterns.Behavioral
{
    #region Observable classes and interfaces

    //Also ISubject
    interface IObservable
    {
        bool Attach(IObserver observer);
        bool Detach(IObserver observer);
        void Notify();
        //used, when higher abstraction is used (class ConcreteObserverAbstract)
        int GetValueForAbstract();
    }

    interface IObserver
    {
        void Update();
        void UpdateWithObservableParam(IObservable observable);
        void UpdateWithResultParam(ValuesClass values);
    }

    class ValuesClass
    {
        public int Value { get; set; } = 12;
    }

    class ConcreteObservable : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();

        public bool Attach(IObserver observer)
        {
            _observers.Add(observer);
            return true;
        }

        public bool Detach(IObserver observer)
        {
            _observers.Remove(observer);
            return true;
        }

        public int GetValueForAbstract()
        {
            return 5;
        }

        public int GetValueForClass()
        {
            return 3;
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update();
                observer.UpdateWithObservableParam(this);
                observer.UpdateWithResultParam(new ValuesClass());
            }
        }
    }

    class ConcreteObserverAbstract : IObserver
    {
        readonly IObservable _observable = null;

        public ConcreteObserverAbstract(IObservable observable)
        {
            _observable = observable;
            _observable.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Abstract Update w/o params: {_observable.GetValueForAbstract()}");
        }

        public void UpdateWithObservableParam(IObservable observable)
        {
            Console.WriteLine($"Abstract Update with IObservable parameter: {observable.GetValueForAbstract()}");
        }

        public void UpdateWithResultParam(ValuesClass values)
        {
            Console.WriteLine($"Abstract Update with ValuesClass parameter: {values.Value}");
        }
    }

    //ConcreteObserver vs. ConcreteObserverAbstract:
    // ConcreteObserver has a class as parameter in constructor, so any mesthod, not defined in interface can be called
    // ConcreteObserverAbstract has an interface, so only methods in interface can be called
    class ConcreteObserver : IObserver
    {
        ConcreteObservable _observable = null;

        public ConcreteObserver(ConcreteObservable observable)
        {
            _observable = observable;
            _observable.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Update w/o params: {_observable.GetValueForAbstract()}, Concrete: {_observable.GetValueForClass()}");
        }

        public void UpdateWithObservableParam(IObservable observable)
        {
            Console.WriteLine($"Update with IObservable parameter: {observable.GetValueForAbstract()}");
        }

        public void UpdateWithResultParam(ValuesClass values)
        {
            Console.WriteLine($"Update with ValuesClass parameter: {values.Value}");
        }
    }
    #endregion

    public class ObserverPatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("Observer Pattern");
            var observable = new ConcreteObservable();
            var concreteObserver = new ConcreteObserver(observable);
            var concreteObserverAbstract = new ConcreteObserverAbstract(observable);
            observable.Notify(); //Notify() is usually called from inside the class, when and where the change happens...
        }
    }
}
