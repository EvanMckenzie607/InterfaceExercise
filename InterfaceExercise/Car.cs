using System;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; } = true;
        public string SoundSystem { get; set; } = "Sony";
        public int NumberOfWheels { get; set; } = 4;
        public bool IsAutomatic { get; set; } = true;
        public int TopSpeed { get; set; } = 150;
        public string DriveTrain { get; set; } = "CVT";
        public string Logo { get; set; } = "Ford";
        public string Slogan { get; set; } = "Built Ford Tough";

        public void VehicleInfo()
        {
            Console.WriteLine($"Ford Fusion\n" +
                $"-----------");
            Console.WriteLine($"Available Trunk...{HasTrunk}");
            Console.WriteLine($"Premium Sound System: {SoundSystem}");
        }
    }
}
