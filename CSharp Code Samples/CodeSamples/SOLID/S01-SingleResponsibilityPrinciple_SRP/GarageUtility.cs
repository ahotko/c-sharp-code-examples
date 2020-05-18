using System;

namespace CodeSamples.SOLID.S01_SingleResponsibilityPrinciple_SRP
{
    public class GarageUtility : IGarageUtility
    {
        public void CloseDoors()
        {
            Console.WriteLine("...closing the doors");
        }

        public void OpenDoors()
        {
            Console.WriteLine("...opening the doors");
        }

        public void TurnLightsOff()
        {
            Console.WriteLine("...turning on the lights");
        }

        public void TurnLightsOn()
        {
            Console.WriteLine("...turning off the lights");
        }
    }
}
