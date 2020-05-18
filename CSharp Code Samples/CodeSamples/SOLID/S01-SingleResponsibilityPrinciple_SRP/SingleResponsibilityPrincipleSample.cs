namespace CodeSamples.SOLID.S01_SingleResponsibilityPrinciple_SRP
{
    public class SingleResponsibilityPrincipleSample : SampleExecute
    {
        public override void Execute()
        {
            Title("SOLID - SingleResponsibilityPrinciple");
            Section("SRP");

            var garage = new GarageStation(new GarageUtility());
            garage.OpenForService();
            garage.ServiceAVehicle();
            garage.CloseGarage();
        }
    }
}
