using System;
using System.Collections.Generic;

namespace CodeSamples.Patterns.Creational
{
    #region Factory Method Pattern Classes and Interfaces
    abstract class VeganStuff { }
    class Bread : VeganStuff { }
    class Cheese : VeganStuff { }
    class Tomato : VeganStuff { }
    class Lettuce : VeganStuff { }
    class Mayonnaise : VeganStuff { }

    abstract class Sandwich
    {
        public Sandwich()
        {
            MakeSandwich();
        }

        //Factory Method
        public abstract void MakeSandwich();

        public List<VeganStuff> Ingredients { get; } = new List<VeganStuff>();

        public void ListIngredients()
        {
            foreach(var ingredient in Ingredients)
            {
                Console.WriteLine($"  ingredient = {ingredient.GetType().Name}");
            }
        }
    }

    class VeggieSandwich : Sandwich
    {
        public override void MakeSandwich()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new Cheese());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }
    }

    class TomatoSandwich : Sandwich
    {
        public override void MakeSandwich()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new Bread());
        }
    }
    #endregion

    public class FactoryMethodPatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("Factory Method Pattern");
            Section("Veggie Sandwich");
            var veggieSandwich = new VeggieSandwich();
            veggieSandwich.ListIngredients();
            Section("Tomato Sandwich");
            var tomatoSandwich = new TomatoSandwich();
            tomatoSandwich.ListIngredients();
        }
    }
}
