using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool Has3rdRowSeating { get; set; }  = true;
        public int WindowTint { get; set; } = 70;
        public int NumberOfWheels { get; set; } = 4;
        public bool IsAutomatic { get; set; } = true;
        public int TopSpeed { get; set; } = 110;
        public string DriveTrain { get; set; } = "6 Speed Automatic";
        public string Logo { get; set; } = "Hyndai";
        public string Slogan { get; set; } = "New Thinking, New Possibilities";

        public void VehicleInfo()
        {
            Console.WriteLine("Hyundai Tucson\n" +
                "--------------");
            Console.WriteLine($"Available 3rd Row Seating...{Has3rdRowSeating}");
            Console.WriteLine($"Window Tint: {WindowTint}%");
        }
    }
}
