using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();

            car1.IsCompact = true;
            car1.VehYear = 2022;
            car1.VehMake = "Rolls Royce";
            car1.VehModel = "Phantom";
            car1.WheelSize = 15.6;
            car1.Name = "BMW";
            car1.Logo = "RR (Eagle Symbol)";
            //car1.EngineIsWorking();
            //car1.HornIsWorking();
            //car1.ZeroTo60Speed(4.1);

            SUV suv1 = new SUV();

            suv1.CabinSize = "Huge";
            suv1.HeightFromGround = 2;
            suv1.VehYear = 2021;
            suv1.VehMake = "Lincoln";
            suv1.VehModel = "Navigator";
            suv1.WheelSize = 17.2;
            suv1.Name = "Ford Motor Company";
            suv1.Logo = "Lincoln (Cross Symbol)";
            //suv1.EngineIsWorking();
            //suv1.HornIsWorking();

            Truck truck1 = new Truck();

            truck1.BedSize = 8;
            truck1.HasFrontBenchSeat = false;
            truck1.VehYear = 2018;
            truck1.VehMake = "Ford";
            truck1.VehModel = "F-150";
            truck1.WheelSize = 16.8;
            truck1.Name = "Ford Motor Company";
            truck1.Logo = "Ford F-150 Symbols";
            //truck1.EngineIsWorking();
            //truck1.HornIsWorking();

            var vehicles = new List<IVehicle>();

            vehicles.Add(car1);
            vehicles.Add(suv1);
            vehicles.Add(truck1);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"The {veh.VehYear} {veh.VehMake} {veh.VehModel} has a wheel size of: {veh.WheelSize}, " +
                                  $"and is made by {veh.Name}.");
                Console.WriteLine("");
            }
        }
    }
}
