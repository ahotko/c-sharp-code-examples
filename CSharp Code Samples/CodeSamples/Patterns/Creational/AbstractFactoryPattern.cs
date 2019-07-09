using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Patterns.Creational
{
    #region Abstract Factory Pattern Classes and Interfaces
    interface IElement
    {
        void Paint();
    }

    interface IGuiFactory
    {
        IElement CreateElement();
    }

    #region Windows
    class WindowsElement : IElement
    {
        public void Paint()
        {
            Console.WriteLine($"WindowsElement Paint");
        }
    }

    class WindowsGuiFactory : IGuiFactory
    {
        public IElement CreateElement()
        {
            return new WindowsElement();
        }
    }
    #endregion

    #region Linux
    class LinuxElement : IElement
    {
        public void Paint()
        {
            Console.WriteLine($"LinuxElement Paint");
        }
    }

    class LinuxGuiFactory : IGuiFactory
    {
        public IElement CreateElement()
        {
            return new LinuxElement();
        }
    }
    #endregion

    #region OsX
    class MacOsXElement : IElement
    {
        public void Paint()
        {
            Console.WriteLine($"MacOsXElement Paint");
        }
    }

    class MacOsXGuiFactory : IGuiFactory
    {
        public IElement CreateElement()
        {
            return new MacOsXElement();
        }
    }
    #endregion

    #endregion

    public class AbstractFactoryPatternSample : SampleExecute
    {
        public override void Execute()
        {
            Section("Abstract Factory Pattern");
            IGuiFactory guiFactory = new WindowsGuiFactory();
            var element = guiFactory.CreateElement();
            element.Paint();
            //
            guiFactory = new LinuxGuiFactory();
            element = guiFactory.CreateElement();
            element.Paint();
            //
            guiFactory = new MacOsXGuiFactory();
            element = guiFactory.CreateElement();
            element.Paint();
        }
    }
}
