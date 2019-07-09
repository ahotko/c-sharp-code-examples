using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Patterns.Behavioral
{
    #region Abstract Pattern classes and interfaces
    abstract class State
    {
        public abstract void Handle(Context context);
    }

    class ConcreteStateRead : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("...reading");
            context.State = new ConcreteStateWrite();
        }
    }

    class ConcreteStateWrite : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("...writing");
            context.State = new ConcreteStateWait();
        }
    }

    class ConcreteStateWait : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("...waiting");
            context.State = new ConcreteStateRead();
        }
    }

    class Context
    {
        private State _state;

        public Context(State state)
        {
            _state = state;
        }

        public State State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine($"New state: {_state.GetType().Name}");
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
    #endregion

    public class StatePatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("State Pattern");
            var state = new Context(new ConcreteStateRead());
            state.Request();
            state.Request();
            state.Request();
            state.Request();
            state.Request();
        }
    }
}
