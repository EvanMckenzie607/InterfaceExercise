using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            ////Create 2 Interfaces called IVehicle & ICompany

            ////Create 3 classes called Car , Truck , & SUV

            ////In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            ////In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            ////In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var fusion = new Car();
            var ram = new Truck();
            var Tucson = new SUV();
            List<IVehicle> availableVehicles = new List<IVehicle>();
            availableVehicles.Add(fusion);
            availableVehicles.Add(ram);
            availableVehicles.Add(Tucson);
            foreach (var item in availableVehicles)
            {
                item.VehicleInfo();
                Console.WriteLine($"Brand: {item.Logo}");
                Console.WriteLine($"{item.Slogan}");
                Console.WriteLine($"This is a {item.NumberOfWheels} wheel vehicle.");
                Console.WriteLine($"Vehicle is Automatic...{item.IsAutomatic}");
                Console.WriteLine($"Drivetrain: {item.DriveTrain}");
                Console.WriteLine($"Top Speed: {item.TopSpeed}");
                Console.WriteLine($"");
                Console.WriteLine($"");
            }
        }
    }
}
