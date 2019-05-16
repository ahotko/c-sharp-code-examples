using System;

namespace CodeSamples.Alterations
{
    public class EntityOne
    {
        public int ValueOne { get; set; } = 1;

        //implicit operators do not require explicit cast
        public static implicit operator EntityTwo(EntityOne entity)
        {
            var entityTwo = new EntityTwo()
            {
                ValueTwo = entity.ValueOne
            };
            return entityTwo;
        }
    }

    public class EntityTwo
    {
        public int ValueTwo { get; set; } = 2;

        //explicit operators do not require explicit cast
        public static explicit operator EntityOne(EntityTwo entity)
        {
            var entityOne = new EntityOne()
            {
                ValueOne = entity.ValueTwo
            };
            return entityOne;
        }
    }

    public class EntityConversionSample : SampleExecute
    {
        public override void Execute()
        {
            Title("EntityConversionSampleExecute");
            EntityOne entityOne = new EntityOne();
            EntityTwo entityTwo = new EntityTwo();
            EntityOne entityOneExplicit = (EntityOne)entityTwo;
            EntityTwo entityTwoImplicit = entityOne;
            //
            Console.WriteLine($"Entity One: original = {entityOne.ValueOne}, explicit casting = {entityOneExplicit.ValueOne}");
            Console.WriteLine($"Entity Two: original = {entityTwo.ValueTwo}, implicit casting = {entityTwoImplicit.ValueTwo}");
            //
            Finish();
        }
    }
}
