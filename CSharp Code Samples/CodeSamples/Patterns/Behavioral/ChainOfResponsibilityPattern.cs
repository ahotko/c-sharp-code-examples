using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSamples.Patterns.Behavioral
{
    public class ChainOfResponsibilityPatternSample : SampleExecute
    {
        internal abstract class Handler
        {
            protected Handler Successor { get; private set; }

            public void SetSuccessor(Handler successor)
            {
                this.Successor = successor;
            }

            public abstract void HandleRequest(string deviceName, int request);
        }

        internal class HandlerDeviceKeyboard : Handler
        {
            public override void HandleRequest(string deviceName, int request)
            {
                if (deviceName.Equals("keyboard", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Handled Request {request} for device {deviceName} by {this.GetType().Name}");
                }
                else Successor?.HandleRequest(deviceName, request);
            }
        }

        internal class HandlerDeviceMouse : Handler
        {
            public override void HandleRequest(string deviceName, int request)
            {
                if (deviceName.Equals("mouse", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Handled Request {request} for device {deviceName} by {this.GetType().Name}");
                }
                else Successor?.HandleRequest(deviceName, request);
            }
        }

        internal class HandlerDeviceNetwork : Handler
        {
            public override void HandleRequest(string deviceName, int request)
            {
                if (deviceName.Equals("network", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Handled Request {request} for device {deviceName} by {this.GetType().Name}");
                }
                else Successor?.HandleRequest(deviceName, request);
            }
        }

        public override void Execute()
        {
            Section("Chain of Responsibility Pattern");
            var keyboard = new HandlerDeviceKeyboard();
            var mouse = new HandlerDeviceMouse();
            var network = new HandlerDeviceNetwork();

            keyboard.SetSuccessor(mouse);
            mouse.SetSuccessor(network);

            keyboard.HandleRequest("mouse", 10);
            keyboard.HandleRequest("network", 12);
            keyboard.HandleRequest("keyboard", 102);
            keyboard.HandleRequest("something", 11);
        }
    }
}
