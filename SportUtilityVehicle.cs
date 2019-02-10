namespace DDDHotList
{
    /// <summary>
    /// Sport Utility Vehicle
    /// </summary>
    public class SportUtilityVehicle : MotorVehicle
    {
        public SportUtilityVehicle(string make, string model, int firstGearRpms, int secondGearRpms)
        : base(make, model, firstGearRpms, secondGearRpms)
        {

        }

        public override void TestDrive()
        {
            var speed = PowerTrain.TransferEnergy(800);

            PrintSpeed(speed);

            speed = PowerTrain.TransferEnergy(1200);

            PrintSpeed(speed);
        }
    }
}