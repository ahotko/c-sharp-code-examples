using System;

namespace CodeSamples.Patterns.Other
{
    class Person : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Address : IEntity
    {
        public int Id { get; set; }
        public string Street { get; set; }
    }

    interface IUnitOfWork
    {
        IRepository<Person> PersonRepository { get; }
        IRepository<Address> AddressRepository { get; }
        void Complete();
    }

    class UnitOfWork : IUnitOfWork
    {
        public IRepository<Person> PersonRepository => throw new NotImplementedException();

        public IRepository<Address> AddressRepository => throw new NotImplementedException();

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }

    public class UnitOfWorkPattern : SampleExecute
    {
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
