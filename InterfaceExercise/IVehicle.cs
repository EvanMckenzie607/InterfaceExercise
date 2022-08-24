using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; } 
        public int TopSpeed { get; set; }
        public string DriveTrain { get; set; }
        public void VehicleInfo();
    }
}
