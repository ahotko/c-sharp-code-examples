using System;

namespace CodeSamples.SOLID.S01_SingleResponsibilityPrinciple_SRP
{
    /// <summary>
    /// Sample used: https://www.dotnettricks.com/learn/designpatterns/solid-design-principles-explained-using-csharp
    /// </summary>
    public class GarageStation
    {
        private IGarageUtility _garageUtility;

        public GarageStation(IGarageUtility garageUtility)
        {
            _garageUtility = garageUtility;
        }

        public void OpenForService()
        {
            _garageUtility.TurnLightsOn();
            _garageUtility.OpenDoors();
        }

        public void CloseGarage()
        {
            _garageUtility.TurnLightsOff();
            _garageUtility.CloseDoors();
        }

        public void ServiceAVehicle()
        {
            Console.WriteLine("...servicing the vehicle!");
        }
    }
}
