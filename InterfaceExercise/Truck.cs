using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int TowLimit { get; set; } = 8500;
        public int AmountOfDoors { get; set; } = 2;
        public int NumberOfWheels { get; set; } = 6;
        public bool IsAutomatic { get; set; } = false;
        public int TopSpeed { get; set; } = 80;
        public string DriveTrain { get; set; } = "5 Speed Standerd";
        public string Logo { get; set; } = "RAM";
        public string Slogan { get; set; } = "Guts. Glory. Ram.";

        public void VehicleInfo()
        {
            Console.WriteLine("RAM 2500\n" +
                "--------");
            Console.WriteLine($"Tow Limit: {TowLimit} Lbs.");
            Console.WriteLine($"{AmountOfDoors} Door Truck");
        }
    }
}
